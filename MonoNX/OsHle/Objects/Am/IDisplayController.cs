using MonoNX.OsHle.Ipc;
using System.Collections.Generic;

namespace MonoNX.OsHle.Objects.Am
{
    class IDisplayController : IIpcInterface
    {
        private Dictionary<int, ServiceProcessRequest> m_Commands;

        public IReadOnlyDictionary<int, ServiceProcessRequest> Commands => m_Commands;

        public IDisplayController()
        {
            m_Commands = new Dictionary<int, ServiceProcessRequest>()
            {
                //...
            };
        }
    }
}