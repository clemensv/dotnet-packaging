﻿namespace Packaging.Targets.IO
{
    /// <summary>
    /// Represents the type of entry in an archive.
    /// </summary>
    public enum ArchiveEntryType
    {
        /// <summary>
        /// The file as no special type.
        /// </summary>
        None = 0,

        /// <summary>
        /// The file is a 32-bit executable.
        /// </summary>
        Executable32 = 1,

        /// <summary>
        /// The file is a 64-bit executable.
        /// </summary>
        Executable64 = 2,

        /// <summary>
        /// The file is a module (like a .NET assembly)
        /// </summary>
        NetAssembly = 3,

        /// <summary>
        /// This file is a documentation entry
        /// </summary>
        Doc = 4
    }
}
