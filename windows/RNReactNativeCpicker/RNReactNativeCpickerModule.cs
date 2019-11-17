using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace React.Native.Cpicker.RNReactNativeCpicker
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNReactNativeCpickerModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNReactNativeCpickerModule"/>.
        /// </summary>
        internal RNReactNativeCpickerModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNReactNativeCpicker";
            }
        }
    }
}
