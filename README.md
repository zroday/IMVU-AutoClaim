# IMVU-AutoClaim
Imvu automatically DAILY SPIN check (for lazy and forgetful people)<br/>
Keep the application open when minimizing it will automatically go to the windows tray<br/>

* How to use:<br/><br/>
1 - Find and open the application
<figure>
  <img src="https://github.com/zroday/IMVU-AutoClaim/blob/master/IMVU-AutoClaim/Screenshots/step1.png" alt="Step1">
  <figcaption>==============================</figcaption>
</figure>
<br/><br/>
2 - Login with your imvu account
<figure>
  <img src="https://github.com/zroday/IMVU-AutoClaim/blob/master/IMVU-AutoClaim/Screenshots/step2.png" alt="Step2">
  
</figure>
<br/>
<figure>
  <img src="https://github.com/zroday/IMVU-AutoClaim/blob/master/IMVU-AutoClaim/Screenshots/step3.png" alt="Step3">
  <figcaption>==============================</figcaption>
</figure>
<br/><br/>
3 - Wait and then click start
<figure>
  <img src="https://github.com/zroday/IMVU-AutoClaim/blob/master/IMVU-AutoClaim/Screenshots/step4.png" alt="Step4">
  <figcaption>==============================</figcaption>
</figure>
<br/><br/>
4 - All right, now you can minimize the application that it will be in your windows tray
<figure>
  <img src="https://github.com/zroday/IMVU-AutoClaim/blob/master/IMVU-AutoClaim/Screenshots/step5.png" alt="Step5">
  <figcaption>==============================</figcaption>
</figure>
<br/><br/>

CefSharp
<p>Chromium Embedded Framework (CEF) Standard Binary Distribution for Windows
-------------------------------------------------------------------------------

Date:             October 20, 2021

CEF Version:      94.4.11+gc4d96f0+chromium-94.0.4606.81
CEF URL:          https://bitbucket.org/chromiumembedded/cef.git
                  @c4d96f07faf12d765ea8cd48369fe87b2c6bdb13

Chromium Version: 94.0.4606.81
Chromium URL:     https://chromium.googlesource.com/chromium/src.git
                  @471d3c96c601926db975ee03e7ca68011aacd6e0

This distribution contains all components necessary to build and distribute an
application using CEF on the Windows platform. Please see the LICENSING
section of this document for licensing terms and conditions.


CONTENTS
--------

cmake       Contains CMake configuration files shared by all targets.

Debug       Contains libcef.dll, libcef.lib and other components required to
            build and run the debug version of CEF-based applications. By
            default these files should be placed in the same directory as the
            executable and will be copied there as part of the build process.

include     Contains all required CEF header files.

libcef_dll  Contains the source code for the libcef_dll_wrapper static library
            that all applications using the CEF C++ API must link against.

Release     Contains libcef.dll, libcef.lib and other components required to
            build and run the release version of CEF-based applications. By
            default these files should be placed in the same directory as the
            executable and will be copied there as part of the build process.

Resources   Contains resources required by libcef.dll. By default these files
            should be placed in the same directory as libcef.dll and will be
            copied there as part of the build process.

tests/      Directory of tests that demonstrate CEF usage.

  cefclient Contains the cefclient sample application configured to build
            using the files in this distribution. This application demonstrates
            a wide range of CEF functionalities.

  cefsimple Contains the cefsimple sample application configured to build
            using the files in this distribution. This application demonstrates
            the minimal functionality required to create a browser window.

  ceftests  Contains unit tests that exercise the CEF APIs.

  gtest     Contains the Google C++ Testing Framework used by the ceftests
            target.

  shared    Contains source code shared by the cefclient and ceftests targets.


USAGE
-----

Building using CMake:
  CMake can be used to generate project files in many different formats. See
  usage instructions at the top of the CMakeLists.txt file.

Please visit the CEF Website for additional usage information.

https://bitbucket.org/chromiumembedded/cef/


REDISTRIBUTION
--------------

This binary distribution contains the below components.

Required components:

The following components are required. CEF will not function without them.

* CEF core library.
  * libcef.dll

* Crash reporting library.
  * chrome_elf.dll

* Unicode support data.
  * icudtl.dat

* V8 snapshot data.
  * snapshot_blob.bin
  * v8_context_snapshot.bin

Optional components:

The following components are optional. If they are missing CEF will continue to
run but any related functionality may become broken or disabled.

* Localized resources.
  Locale file loading can be disabled completely using
  CefSettings.pack_loading_disabled. The locales directory path can be
  customized using CefSettings.locales_dir_path. 
 
  * locales/
    Directory containing localized resources used by CEF, Chromium and Blink. A
    .pak file is loaded from this directory based on the CefSettings.locale
    value. Only configured locales need to be distributed. If no locale is
    configured the default locale of "en-US" will be used. Without these files
    arbitrary Web components may display incorrectly.

* Other resources.
  Pack file loading can be disabled completely using
  CefSettings.pack_loading_disabled. The resources directory path can be
  customized using CefSettings.resources_dir_path.

  * chrome_100_percent.pak
  * chrome_200_percent.pak
  * resources.pak
    These files contain non-localized resources used by CEF, Chromium and Blink.
    Without these files arbitrary Web components may display incorrectly.

* Direct3D support.
  * d3dcompiler_47.dll
  Support for GPU accelerated rendering of HTML5 content like 2D canvas, 3D CSS
  and WebGL. Without this file the aforementioned capabilities may fail when GPU
  acceleration is enabled (default in most cases). Use of this bundled version
  is recommended instead of relying on the possibly old and untested system
  installed version.

* ANGLE support.
  * libEGL.dll
  * libGLESv2.dll
  Support for rendering of HTML5 content like 2D canvas, 3D CSS and WebGL.
  Without these files the aforementioned capabilities may fail.

* SwANGLE support.
  * vk_swiftshader.dll
  * vk_swiftshader_icd.json
  * vulkan-1.dll
  Support for software rendering of HTML5 content like 2D canvas, 3D CSS and
  WebGL using SwiftShader's Vulkan library as ANGLE's Vulkan backend. Without
  these files the aforementioned capabilities may fail when GPU acceleration is
  disabled or unavailable.

* SwiftShader support
  * swiftshader/libEGL.dll
  * swiftshader/libGLESv2.dll
  Deprecated support for software rendering using SwiftShader's GL libraries.
  Used as an alternative to SwANGLE when the `--use-gl=swiftshader-webgl`
  command-line flag is specified.


LICENSING
---------

The CEF project is BSD licensed. Please read the LICENSE.txt file included with
this binary distribution for licensing terms and conditions. Other software
included in this distribution is provided under other licenses. Please visit
"about:credits" in a CEF-based application for complete Chromium and third-party
licensing information.
</p>
