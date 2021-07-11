# PersonaVoiceClipEditor
![](https://cdn.discordapp.com/attachments/316239186736971776/789541535028084756/unknown.png)  
# What is This?
This tool is for [automatically making dual-language mods](https://shrinefox.com/news/p5-adachi-mod-development-blog-1-dual-language/) when you're batch converting English WAV files to ADX.  
Your English and Japanese WAV directories must contain identically-named files for this to work.
# How to Use
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
[PuyoTools](https://github.com/nickworonekin/puyotools) - AFS Extraction  
[SonicAudioTools](https://github.com/blueskythlikesclouds/SonicAudioTools) - ACB/AWB Unpacking/Repacking  
adxencd - ADX Conversion
