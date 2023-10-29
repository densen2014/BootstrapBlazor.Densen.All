// ********************************** 
// Densen Informatica 中讯科技 
// 作者：Alex Chow
// e-mail:zhouchuanglin@gmail.com 
// **********************************


namespace Microsoft.Extensions.DependencyInjection
{
    /// <summary>
    /// 懒人包服务扩展类
    /// </summary>
    public static class AllCollectionExtensions
    {

        /// <summary>
        /// 增加懒人包服务服务扩展类,<para></para>
        /// </summary>
        /// <param name="services"></param>
        /// <param name="OCRkey"></param>
        /// <param name="OCRurl"></param>
        /// <param name="AIFormkey"></param>
        /// <param name="AIFormurl"></param>
        /// <returns></returns>
        public static IServiceCollection AddAllExtensions(this IServiceCollection services, string OCRkey, string OCRurl, string AIFormkey, string AIFormurl)
        {
            services.AddAIFormExtensions(AIFormkey, AIFormurl);
            services.AddOcrExtensions(OCRkey, OCRurl);
            return services;
        }

    }

}
