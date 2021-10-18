// This code is provided for demonstration purposes and is not intended to represent ideal Unity practices.7
// このコードはデモ用に提供されたもので、理想的なUnityの実践を示すものではありません。
using Epic.OnlineServices;
using Epic.OnlineServices.Auth;
using Epic.OnlineServices.Logging;
using Epic.OnlineServices.Platform;
using UnityEngine;

public class EOSSDKComponent : MonoBehaviour
{
    // Set these values as appropriate. For more information, see the Developer Portal documentation.
    // これらの値を適切に設定してください。詳細については、Developer Portalのドキュメントを参照してください。
    readonly string m_ProductName = "MyUnityApplication";
    readonly string m_ProductVersion = "1.0.0";
    readonly string m_ProductId = "";
    readonly string m_SandboxId = "";
    readonly string m_DeploymentId = "";
    readonly string m_ClientId = "";
    readonly string m_ClientSecret = "";

    public LoginCredentialType m_LoginCredentialType = LoginCredentialType.AccountPortal;
    /// These fields correspond to <see cref="Credentials.Id" /> and <see cref="Credentials.Token" />, and their use differs based on the login type.
    /// For more information, see <see cref="Credentials" /> and the Auth Interface documentation.
    /// これらのフィールドは、<see cref="Credentials.Id" />と<see cref="Credentials.Token" />に対応しており、その使用方法はログインタイプによって異なります。
    /// 詳細については、<see cref="Credentials" />とAuth Interfaceのドキュメントを参照してください。
    public string m_LoginCredentialId = null;
    public string m_LoginCredentialToken = null;

    private static PlatformInterface s_PlatformInterface;
    private const float c_PlatformTickInterval = 0.1f;
    private float m_PlatformTickTimer = 0f;

    void Start()
    {
        var initializeOptions = new InitializeOptions()
        {
            ProductName = m_ProductName,
            ProductVersion = m_ProductVersion
        };

        var initializeResult = PlatformInterface.Initialize(initializeOptions);

        // This code is called each time the game is run in the editor, so we catch the case where the SDK has already been initialized in the editor.
        // このコードは、エディターでゲームを実行するたびに呼び出されるので、エディターですでにSDKが初期化されている場合をキャッチします。
        var isAlreadyConfiguredInEditor = Application.isEditor && initializeResult == Result.AlreadyConfigured;
        if (initializeResult != Result.Success && !isAlreadyConfiguredInEditor)
        {
            throw new System.Exception("Failed to initialize platform: " + initializeResult);
        }

        // The SDK outputs lots of information that is useful for debugging.
        // Make sure to set up the logging interface as early as possible: after initializing.
        // SDKはデバッグに役立つ多くの情報を出力します。
        // ロギングインターフェースの設定は、初期化後のできるだけ早い段階で行うようにしてください。
        LoggingInterface.SetLogLevel(LogCategory.AllCategories, LogLevel.VeryVerbose);
        LoggingInterface.SetCallback((LogMessage logMessage) =>
        {
            Debug.Log(logMessage.Message);
        });

        Debug.Log($"m_DeploymentId : {m_DeploymentId}");
        var options = new Options()
        {
            ProductId = m_ProductId,
            SandboxId = m_SandboxId,
            DeploymentId = m_DeploymentId,
            ClientCredentials = new ClientCredentials()
            {
                ClientId = m_ClientId,
                ClientSecret = m_ClientSecret
            }
        };

        s_PlatformInterface = PlatformInterface.Create(options);
        if (s_PlatformInterface == null)
        {
            throw new System.Exception("Failed to create platform");
        }

        var loginOptions = new LoginOptions()
        {
            Credentials = new Credentials()
            {
                Type = m_LoginCredentialType,
                Id = m_LoginCredentialId,
                Token = m_LoginCredentialToken
            }
        };

        // Ensure platform tick is called on an interval, or this will not callback.
        s_PlatformInterface.GetAuthInterface().Login(loginOptions, null, (LoginCallbackInfo loginCallbackInfo) =>
        {
            if (loginCallbackInfo.ResultCode == Result.Success)
            {
                Debug.Log("Login succeeded");
            }
            else
            {
                Debug.Log("Login returned " + loginCallbackInfo.ResultCode);
            }
        });
    }

    // Calling tick on a regular interval is required for callbacks to work.
    private void Update()
    {
        if (s_PlatformInterface != null)
        {
            m_PlatformTickTimer += Time.deltaTime;

            if (m_PlatformTickTimer >= c_PlatformTickInterval)
            {
                m_PlatformTickTimer = 0;
                s_PlatformInterface.Tick();
            }
        }
    }

    // When you release and shutdown the SDK library, you cannot initialize it again.
    // Make sure this is done at a relevant time in your game's lifecycle.
    // If you are working in editor, it is advised you do not release and shutdown the SDK
    // as you would be required to restart Unity to initialize the SDK again.
    private void OnDestroy()
    {
        if (!Application.isEditor && s_PlatformInterface != null)
        {
            s_PlatformInterface.Release();
            s_PlatformInterface = null;
            PlatformInterface.Shutdown();
        }
    }
}