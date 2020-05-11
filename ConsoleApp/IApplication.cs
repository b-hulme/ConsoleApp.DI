namespace ConsoleApp
{
    /// <summary>
    /// Main Console Application entry point after Dependency Injection configuration
    /// </summary>
    public interface IApplication
    {
        /// <summary>
        /// Main Console Application method
        /// </summary>
        /// <param name="arg">Command line arguments</param>
        /// <returns>Application return value</returns>
        int Execute(string[] arg);
    }
}
