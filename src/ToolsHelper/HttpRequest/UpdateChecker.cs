using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using ToolsHelper.Extensions;
using UpdateChecker;

namespace ToolsHelper.HttpRequests
{
    public class UpdateChecker
    {
        private static readonly ILogger Logger = DefaultLogger.Get(typeof(SystemInfo));
        private const string Owner = @"xisuo67";
        private const string Repo = @"Daily-Newspaper-Tools";

        public string LatestVersionNumber;
        public string LatestVersionUrl;

        public bool Found;

        public event EventHandler NewVersionFound;
        public event EventHandler NewVersionFoundFailed;
        public event EventHandler NewVersionNotFound;

        public const string Name = @"Daily-Newspaper";
        public const string Copyright = @"Copyright © 2022-present xisuo67";
        public const string Version = @"1.0.1";

        public const string FullVersion = Version +
#if SelfContained
#if Is64Bit
            @" x64" +
#else
            @" x86" +
#endif
#endif
#if DEBUG
        @" Debug";

        public UpdateChecker()
        {
        }
#else
        @"";
#endif

        public async void Check(bool notifyNoFound)
        {
            try
            {
                var updater = new GitHubReleasesUpdateChecker(
                    Owner,
                    Repo,
                    false,
                    Version);

                //var userAgent = config.ProxyUserAgent;
                //var proxy = CreateProxy(config);
                //using var client = CreateClient(true, proxy, userAgent, config.ConnectTimeout * 1000);

                //var res = await updater.CheckAsync(client, default);
                var res = await updater.CheckAsync(default);
                LatestVersionNumber = updater.LatestVersion;
                Found = res;
                if (Found)
                {
                    LatestVersionUrl = updater.LatestVersionUrl;
                    NewVersionFound?.Invoke(this, EventArgs.Empty);
                }
                else
                {
                    if (notifyNoFound)
                    {
                        NewVersionNotFound?.Invoke(this, EventArgs.Empty);
                    }
                }
            }
            catch (Exception e)
            {
                Logger.Error(e.ToString());
                if (notifyNoFound)
                {
                    NewVersionFoundFailed?.Invoke(this, EventArgs.Empty);
                }
            }
        }
    }
}
