using UnityEngine;

using System;

namespace OpenCVForUnity
{
		abstract public class DisposableOpenCVObject : DisposableObject
		{
				
				internal IntPtr nativeObj;
				
				protected DisposableOpenCVObject ()
            : this(true)
				{
				}
			
				protected DisposableOpenCVObject (IntPtr ptr)
            : this(ptr, true)
				{
				}
				
				protected DisposableOpenCVObject (bool isEnabledDispose)
            : this(IntPtr.Zero, isEnabledDispose)
				{
				}
				
				protected DisposableOpenCVObject (IntPtr ptr, bool isEnabledDispose)
            : base(isEnabledDispose)
				{
						this.nativeObj = ptr;
				}
				
				protected override void Dispose (bool disposing)
				{


						try {
								if (disposing) {
								}
								nativeObj = IntPtr.Zero;

						} finally {
								base.Dispose (disposing);
						}

				}
     
		}
}
