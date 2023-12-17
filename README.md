# PersonaVoiceClipEditor
![](https://i.imgur.com/GaVoP8j.gif)
# What is This?
This tool is for batch converting ``.wav`` audio files to/from ``.adx``/``.hca`` formats, for games that use CriWare audio such as the Persona series.  
This may be useful for [automatically making dual-language mods](https://shrinefox.com/news/p5-adachi-mod-development-blog-1-dual-language/), encrypting audio, unpacking/repacking ``.afs``/``.acb`` archives, or quickly renaming audio files.

# Requirements
- Install [.NET Framework 4.8 Runtime](https://dotnet.microsoft.com/en-us/download/dotnet-framework/thank-you/net48-web-installer)

# Settings
## Menu Strip
**File**: Save/load the current state of form controls to/from ``.json``.  
**Toggle Theme**: Swap the appearance of the program between dark/light mode.  
**Encryption Preset**: Load pre-existing settings based on specific games/platforms with known encryption keys and audio/archive formats.  
**Archive Format**: Choose between ``.acb`` and ``.afs`` for repacking a folder of audio files in the "Archives" tab.  
**Sound Format**: Choose between ``.adx``, ``.hca`` and ``.wav`` for converting audio files in the "Encoding" tab.  
## Renaming
**Drag .txt w/ Ordered Filenames**: See below "How to Support Dual Languages" for a detailed explanation.  
**Source Sound Files Path**: The folder containing sound files used in the ``.txt`` list.  
**Renamed Files Output Path**: The folder where copied and renamed files from the source folder will be created.  
**Suffix**: A string that follows the ID in the filename. i.e. ``00005.adx`` would become ``00005_streaming.adx`` with "_streaming" as the suffix.  
**Append OG Name**: Appends the name of the source audio file to the end of the renamed file, after the suffix. Useful for identifying tracks when using Reloaded II's FEmulator, which allows this.  
i.e. ``00005_streaming.adx`` would become ``00005_streaming_originalfilename.adx`` if the source file was ``originalfilename.adx``.  
**Left Padding**: The number of digits that comprise the ID. Un-filled digits will be zero. For instance, an ID of ``234`` with a Left Padding of ``5`` becomes ``00234``.  
**Start ID**: Which ID to start counting up from. Useful when you're replacing a sequence of some, but not all audio files in the middle of an archive.  
i.e. with start ID ``30``, the first file to be generated will be named ``00030_streaming.adx``  
**Copy and Rename Files**: Using the above settings, files from the source folder will be copied and renamed to the output folder in the order they appear in the list, with the ID counting up by 1 each time.
## Archives
**Drag Archive to Extract**: Select an ``.acb``/``.afs`` archive to extract to a folder. The folder will appear next to the original archive.  
**Drag Folder to Repack**: Choose a folder containing audio files to repack into the selected archive format. For ``.acb``, it must be next to the original ``.acb``/``.awb`` pair **which will be overwritten**. The original **.AFS** may be overwritten as well if the folder being repacked is in the same directory, but you can move it somewhere else first (it doesn't need to be next to the original).
# How to Support Dual Languages
1. Make a spreadsheet with all the filenames of your English wavs in the order of the files extracted from an AWB (P5) or AFS (P3/P4). Line up the filenames of the replacement clips in another column. Leave cells blank where no replacement is needed.
![](https://64.media.tumblr.com/528ca52de04e3816460ec84ddf8e9b6d/tumblr_inline_pdfuax2BVH1rp7sxh_1280.png)  
3. Copy the column with the replacement filenames to a .txt document, and drag it onto the box in the "Renaming" tab. (Hint: Select both the filename/transcription columns when copying to retain that info in the program!)
![](https://64.media.tumblr.com/d497ba0752f3184f149f614460f45042/tumblr_inline_pdfukbQ0dY1rp7sxh_1280.png)  
4. Specify the path to your WAV directory.  
![](https://64.media.tumblr.com/b702119b521578abaa7f56b213bc001c/tumblr_inline_pdfuzxPdXC1rp7sxh_1280.png)  
5. Specify the path to the existing ADX directory. The filenames and order of clips here will be matched to your WAV list for reference.  
Please note **these files will be overwritten** so back them up before proceeding if needed.
![](https://64.media.tumblr.com/cba98f6a50228cb1b44cf5051e920c3f/tumblr_inline_pdfuwcN0dm1rp7sxh_1280.png)  
6. Specify the path to your WAV list .txt.  
7. Click Replace, wait for it to finish and repeat for each language you have WAVs for.
# Dependencies
[AFSLib](https://github.com/MaikelChan/AFSLib) - ``.AFS`` Extract/Repack  
[VGAudio](https://github.com/Thealexbarney/VGAudio) - ``.adx``/``.hca``/``.wav`` encode/decode  
[ACBEditor](https://github.com/blueskythlikesclouds/SonicAudioTools) - ``.ACB``/``.AWB`` Unpacking/Repacking  
[MetroSet-UI](https://github.com/N-a-r-w-i-n/MetroSet-UI) - Dark/Light Themes for WinForms Controls  
[ShrineFox.IO](https://github.com/ShrineFox/ShrineFox.IO) - Shared Code Library for my projects
