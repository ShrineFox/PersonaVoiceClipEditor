# PersonaVoiceClipEditor
![](https://i.imgur.com/EAIbuzh.gif)  
# What is This?
This tool is for batch converting multiple .adx files for games that use CriWare audio, such as the Persona series. This may be useful for [automatically making dual-language mods](https://shrinefox.com/news/p5-adachi-mod-development-blog-1-dual-language/), encrypting audio, unpacking/repacking .afs/.acb archives, or quickly renaming audio files.

# How to Support Dual Languages
1. Make a spreadsheet with all the filenames of your English wavs in the order of the files extracted from an AWB (P5) or AFS (P3/P4). Line up the filenames of the replacement clips in another column. Leave cells blank where no replacement is needed.
![](https://64.media.tumblr.com/528ca52de04e3816460ec84ddf8e9b6d/tumblr_inline_pdfuax2BVH1rp7sxh_1280.png)  
3. Copy the column with the replacement filenames to a .txt document, and specify the path in the program.  
![](https://64.media.tumblr.com/d497ba0752f3184f149f614460f45042/tumblr_inline_pdfukbQ0dY1rp7sxh_1280.png)  
4. Specify the path to your WAV directory.  
![](https://64.media.tumblr.com/b702119b521578abaa7f56b213bc001c/tumblr_inline_pdfuzxPdXC1rp7sxh_1280.png)  
5. Specify the path to the existing ADX directory. The filenames and order of clips here will be matched to your WAV list for reference.  
Please note **these files will be overwritten** so back them up before proceeding if needed.
![](https://64.media.tumblr.com/cba98f6a50228cb1b44cf5051e920c3f/tumblr_inline_pdfuwcN0dm1rp7sxh_1280.png)  
6. Specify the path to your WAV list .txt.  
7. Click Replace, wait for it to finish and repeat for each language you have WAVs for.
# Dependencies
[AFSLib](https://github.com/MaikelChan/AFSLib) - AFS Extract/Repack
[VGAudio](https://github.com/Thealexbarney/VGAudio) - .adx/.hca/.wav encode/decode
[ACBEditor](https://github.com/blueskythlikesclouds/SonicAudioTools) - ACB/AWB Unpacking/Repacking  
[yet-another-tab-control](https://github.com/realistschuckle/yet-another-tab-control) - Dark TabControl Appearance
[DarkUI](https://github.com/RobinPerris/DarkUI) - Dark WinForms Controls
[ShrineFox.IO](https://github.com/ShrineFox/ShrineFox.IO) - Shared Code Library for my projects
