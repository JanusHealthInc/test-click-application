using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using TestClickApplication.WinAPI;

namespace TestClickApplication.OS
{
    public delegate void MouseEvtHandler();

    /// <summary>
    /// Observer class that sets up hooks into the System (Windows only at this point)
    /// so that we can monitor events
    /// </summary>
    public class SystemObserver
    {

        /// <summary>
        /// The SetWindowsHookEx function installs an application-defined hook procedure into a hook chain. 
        /// You would install a hook procedure to monitor the system for certain types of events. These events 
        /// are associated either with a specific thread or with all threads in the same desktop as the calling thread. 
        /// </summary>
        /// <param name="idHook">
        /// [in] Specifies the type of hook procedure to be installed. This parameter can be one of the following values.
        /// </param>
        /// <param name="lpfn">
        /// [in] Pointer to the hook procedure. If the dwThreadId parameter is zero or specifies the identifier of a 
        /// thread created by a different process, the lpfn parameter must point to a hook procedure in a dynamic-link 
        /// library (DLL). Otherwise, lpfn can point to a hook procedure in the code associated with the current process.
        /// </param>
        /// <param name="hMod">
        /// [in] Handle to the DLL containing the hook procedure pointed to by the lpfn parameter. 
        /// The hMod parameter must be set to NULL if the dwThreadId parameter specifies a thread created by 
        /// the current process and if the hook procedure is within the code associated with the current process. 
        /// </param>
        /// <param name="dwThreadId">
        /// [in] Specifies the identifier of the thread with which the hook procedure is to be associated. 
        /// If this parameter is zero, the hook procedure is associated with all existing threads running in the 
        /// same desktop as the calling thread. 
        /// </param>
        /// <returns>
        /// If the function succeeds, the return value is the handle to the hook procedure.
        /// If the function fails, the return value is NULL. To get extended error information, call GetLastError.
        /// </returns>
        /// <remarks>
        /// https://learn.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-setwindowshookexa
        /// </remarks>
        [DllImport("user32")]
        protected static extern IntPtr SetWindowsHookExA(
            int idHook,
            HookProc lpfn,
            IntPtr hMod,
            int dwThreadId);

        private IntPtr mouseHandle;

        public SystemObserver()
        {
        }

        public void Start()
        {
            if (mouseHandle == IntPtr.Zero)
            {
                mouseHandle = SetWindowsHookExA(
                    HookEvents.WH_MOUSE_LL,
                    mouseHookProc,
                    Marshal.GetHINSTANCE(
                        Assembly.GetExecutingAssembly().GetModules()[0]
                        ),
                    0
                );

                // TODO: throw an error here
            }
        }

        /// <summary>
        /// Hook Process for mouse low level events
        /// </summary>
        /// <param name="nCode"></param>
        /// <param name="wParam">See MouseLLEvents class in WinAPI Namespace</param>
        /// <param name="lParam">Marshals to MouseLLHookStruct in WinAPI Namespace</param>
        /// <returns></returns>
        private IntPtr mouseHookProc(int nCode, IntPtr wParam, IntPtr lParam)
        {
            // Please see HookProc to understand what these IntPtrs marshall to.
            // Add your click logic here
            return IntPtr.Zero;
        }
    }
}
