using System.Reflection;

namespace osu.Game.Resources.Icons
{
    public class Win32Icon
    {
        public readonly Assembly Assembly;
        public readonly int Id;

        /// <summary>
        /// String that can be used with the <c>DefaultIcon</c> key in the registry to point to this icon.
        /// </summary>
        // The icon id needs to be negative, see https://devblogs.microsoft.com/oldnewthing/20100505-00/?p=14153
        public string RegistryString => $"{Assembly.Location},{-Id}";

        public override string ToString() => RegistryString;

        public Win32Icon(Assembly assembly, int id)
        {
            Assembly = assembly;
            Id = id;
        }

        internal Win32Icon(int id)
            : this(OsuResources.ResourceAssembly, id)
        {
        }
    }
}
