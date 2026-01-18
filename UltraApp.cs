using Microsoft.Extensions.DependencyInjection;
using System.Windows;
using YiboFile.Services.Features;

namespace YiboFile
{
    public class UltraApp : YiboFile.App
    {
        protected override void ConfigureServices(IServiceCollection services)
        {
            // 先调用基类注册基础服务
            base.ConfigureServices(services);

            // 注册 Pro 标签服务 (Ultra 包含 Pro 功能)
            // 注意：Ultra 需要同时引用 Core 和 Pro，或者将 TagService 逻辑也包含进来
            // 由于 Pro 现在是 WinExe，直接引用可能会有问题。
            // 实际上，我们只是需要 TagService 的代码。
            // 这里的最佳实践是将 TagService 剥离为 Library，但目前为了简化，
            // 我们可以假设 Ultra 项目也包含了 TagService 的文件链接，或者 Ultra 项目引用了 Pro 项目（如果 Pro 同时输出 DLL）。
            
            // 临时的解决方案：
            // 如果 Ultra 项目引用了 Pro 项目，TagService 类型应该可见。
             services.AddSingleton<ITagService, YiboFile.Services.Features.TagService>();
            
            // 注册 Ultra 专属服务
            // services.AddSingleton<IUltraService, UltraService>();
        }
    }
}
