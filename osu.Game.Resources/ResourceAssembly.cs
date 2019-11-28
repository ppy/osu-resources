using System.Reflection;

namespace osu.Game.Resources
{
    public static class ResourceAssembly
    {
        public static Assembly Assembly => typeof(ResourceAssembly).Assembly;
    }
}
