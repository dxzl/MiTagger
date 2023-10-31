# MiTagger
Simple C# tagger for Windows based on Mono's TaglibSharp.  MiTagger can read and write many song tag formats including MP3, WMA and WAV.

To build:
In Visual Studio install the "Windows Installer Projects" add-on. Unzip MiTagger and https://github.com/mono/taglib-sharp into your Visual Studio Projects directory. Run Visual Studio and open MiTagger.sln. Right-click TaglibSharp and do Clean then Build. Add a reference to the TagLibSharp DLL by expanding MiTagger then right-click References->Add Reference and check the box Projects->TaglibSharp. Right-click MiTagger and do Clean then Build. You will get a warning for TaglibSharp.DLL that it's targeted for .NETcore. I've ignored this warning and everything works OK (so-far...). Now build the installer .msi by right-clicking MiTagger Installer->Build.

Contact: dxzl@live.com

![Preview](mitagger.png)