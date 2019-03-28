﻿/* ----------------------------------------------------------------------
Axiom UI
Copyright (C) 2017-2019 Matt McManis
https://github.com/MattMcManis/Axiom
https://axiomui.github.io
mattmcmanis@outlook.com

This program is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with this program.If not, see <http://www.gnu.org/licenses/>. 
---------------------------------------------------------------------- */

using System.Linq;
// Disable XML Comment warnings
#pragma warning disable 1591
#pragma warning disable 1587
#pragma warning disable 1570

namespace Axiom
{
    public class Presets
    {
        public static void Preset(ViewModel vm)
        {
            // -------------------------
            // Custom
            // -------------------------
            //// Custom ComboBox Editable
            //if (vm.Preset_SelectedItem == "Custom")
            //{
            //    //vm.Preset.IsEditable = true;
            //}
            //// Maintain Editable Combobox while typing
            //if (vm.Preset.IsEditable == true)
            //{
            //    //vm.Preset.IsEditable = true;

            //    // Clear Custom Text
            //    //vm.Preset.Text = string.Empty;
            //}

            //System.Windows.MessageBox.Show(vm.Preset_SelectedItem); //debug

            // ---------------------------------------------------------------------------
            // Default
            // ---------------------------------------------------------------------------
            if (vm.Preset_SelectedItem == "Preset" ||
                vm.Preset_SelectedItem == "Default")
            {
                // -------------------------
                // Default Video
                // -------------------------
                if (vm.Format_Container_SelectedItem == "webm" ||
                    vm.Format_Container_SelectedItem == "mp4" ||
                    vm.Format_Container_SelectedItem == "mkv" ||
                    vm.Format_Container_SelectedItem == "m2v" ||
                    vm.Format_Container_SelectedItem == "mpg" ||
                    vm.Format_Container_SelectedItem == "avi" ||
                    vm.Format_Container_SelectedItem == "ogv" ||
                    vm.Format_Container_SelectedItem == "jpg" ||
                    vm.Format_Container_SelectedItem == "png" ||
                    vm.Format_Container_SelectedItem == "webp")
                {
                    //vm.Preset.IsEditable = false;

                    // Format
                    //vm.Format_Container_SelectedItem = vm.Format_Container_Items.FirstOrDefault();
                    vm.Format_Container_SelectedItem = "webm";
                    vm.Format_Cut_SelectedItem = "No";
                    vm.Format_CutStart_Hours_Text = "00";
                    vm.Format_CutStart_Minutes_Text = "00";
                    vm.Format_CutStart_Seconds_Text = "00";
                    vm.Format_CutStart_Milliseconds_Text = "000";
                    vm.Format_CutEnd_Hours_Text = "00";
                    vm.Format_CutEnd_Minutes_Text = "00";
                    vm.Format_CutEnd_Seconds_Text = "00";
                    vm.Format_CutEnd_Milliseconds_Text = "000";
                    
                    // Video
                    //vm.Video_Codec_SelectedItem = "VP8";
                    vm.Video_EncodeSpeed_SelectedItem = "Medium";
                    vm.Video_Quality_SelectedItem = "Auto";
                    vm.Video_Pass_SelectedItem = "CRF";
                    vm.Video_Bitrate_Text = "";
                    vm.Video_Minrate_Text = "";
                    vm.Video_Maxrate_Text = "";
                    vm.Video_Bufsize_Text = "";
                    vm.Video_Scale_SelectedItem = "Source";

                    vm.Video_ScalingAlgorithm_SelectedItem = "auto";


                    vm.Video_AspectRatio_SelectedItem = "auto";

                    vm.Video_FPS_SelectedItem = "auto";

                    // Subtitle
                    //vm.Subtitle_Codec_SelectedItem = "None";
                    vm.Subtitle_Stream_SelectedItem = "none";

                    // Audio
                    //vm.Audio_Codec_SelectedItem = "Vorbis";
                    vm.Audio_Stream_SelectedItem = "all";
                    vm.Audio_Channel_SelectedItem = "Source";
                    vm.Audio_Quality_SelectedItem = "Auto";
                    vm.Audio_SampleRate_SelectedItem = "auto";
                    vm.Audio_BitDepth_SelectedItem = "auto";
                    vm.Audio_Volume_Text = "100";
                    vm.Audio_HardLimiter_Value = 1;

                    // special rules for webm
                    if (vm.Format_Container_SelectedItem == "webm")
                    {
                        vm.Subtitle_Stream_SelectedItem = "none";
                        vm.Audio_Stream_SelectedItem = "1";
                        //vm.Video_Optimize_SelectedItem = "Web";
                    }
                    else
                    {
                        vm.Video_Optimize_SelectedItem = "None";
                        vm.Video_Optimize_Tune_SelectedItem = "none";
                        vm.Video_Optimize_Profile_SelectedItem = "main";
                        vm.Video_Optimize_Level_SelectedItem = "5.2";
                    }

                    // Filters
                    vm.FiltersSetDefault();

                }

                // -------------------------
                // Default Audio
                // -------------------------
                else if (vm.Format_Container_SelectedItem == "m4a" ||
                         vm.Format_Container_SelectedItem == "mp3" ||
                         vm.Format_Container_SelectedItem == "ogg" ||
                         vm.Format_Container_SelectedItem == "flac" ||
                         vm.Format_Container_SelectedItem == "wav")
                {
                    //vm.Preset.IsEditable = false;

                    // Format
                    //vm.Format_Container_SelectedItem = vm.Format_Container_Items.FirstOrDefault();
                    //vm.Format_Container_SelectedIndex = 1;
                    vm.Format_Container_SelectedItem = "mp3";
                    vm.Format_Cut_SelectedItem = "No";
                    vm.Format_CutStart_Hours_Text = "00";
                    vm.Format_CutStart_Minutes_Text = "00";
                    vm.Format_CutStart_Seconds_Text = "00";
                    vm.Format_CutStart_Milliseconds_Text = "000";
                    vm.Format_CutEnd_Hours_Text = "00";
                    vm.Format_CutEnd_Minutes_Text = "00";
                    vm.Format_CutEnd_Seconds_Text = "00";
                    vm.Format_CutEnd_Milliseconds_Text = "000";

                    // Video
                    vm.Video_Codec_SelectedItem = "None";
                    vm.Video_EncodeSpeed_SelectedItem = "None";
                    vm.Video_Quality_SelectedItem = "None";
                    vm.Video_Pass_SelectedItem = "auto";
                    vm.Video_Bitrate_Text = "";
                    vm.Video_Minrate_Text = "";
                    vm.Video_Maxrate_Text = "";
                    vm.Video_Bufsize_Text = "";
                    vm.Video_PixelFormat_SelectedItem = "none";
                    vm.Video_FPS_SelectedItem = "auto";
                    vm.Video_Optimize_SelectedItem = "None";
                    vm.Video_Scale_SelectedItem = "Source";
                    vm.Video_ScalingAlgorithm_SelectedItem = "auto";
                    vm.Video_AspectRatio_SelectedItem = "auto";

                    // Subtitle
                    vm.Subtitle_Codec_SelectedItem = "None";
                    vm.Subtitle_Stream_SelectedItem = "none";

                    // Audio
                    vm.Audio_Codec_SelectedItem = "LAME";
                    vm.Audio_Stream_SelectedItem = "1";
                    vm.Audio_Channel_SelectedItem = "Source";
                    vm.Audio_Quality_SelectedItem = "Auto";
                    vm.Audio_CompressionLevel_SelectedItem = "auto";
                    vm.Audio_SampleRate_SelectedItem = "auto";
                    // special rules for PCM codec
                    if (vm.Audio_Codec_SelectedItem == "PCM")
                    {
                        vm.Audio_BitDepth_SelectedItem = "24";
                    }
                    else
                    {
                        vm.Audio_BitDepth_SelectedItem = "auto";
                    }

                    vm.Audio_Volume_Text = "100";
                    vm.Audio_HardLimiter_Value = 1;

                    // Filters
                    vm.FiltersSetDefault();
                }
            }


            // ---------------------------------------------------------------------------
            // Web
            // ---------------------------------------------------------------------------
            // -------------------------
            // HTML5
            // -------------------------
            else if (vm.Preset_SelectedItem == "HTML5")
            {
                //vm.Preset.IsEditable = false;

                // Format
                vm.Format_Container_SelectedItem = "webm";
                vm.Format_Cut_SelectedItem = "No";
                vm.Format_CutStart_Hours_Text = "00";
                vm.Format_CutStart_Minutes_Text = "00";
                vm.Format_CutStart_Seconds_Text = "00";
                vm.Format_CutStart_Milliseconds_Text = "000";
                vm.Format_CutEnd_Hours_Text = "00";
                vm.Format_CutEnd_Minutes_Text = "00";
                vm.Format_CutEnd_Seconds_Text = "00";
                vm.Format_CutEnd_Milliseconds_Text = "000";

                // Video
                vm.Video_Codec_SelectedItem = "VP8";
                vm.Video_EncodeSpeed_SelectedItem = "Medium";
                vm.Video_Quality_SelectedItem = "Medium";
                vm.Video_Pass_SelectedItem = "CRF";
                //vm.Video_Bitrate_Text = ""; // use quality preset bitrate
                vm.Video_Minrate_Text = "";
                vm.Video_Maxrate_Text = "";
                vm.Video_Bufsize_Text = "";
                vm.Video_PixelFormat_SelectedItem = "yuv420p";
                vm.Video_FPS_SelectedItem = "auto";
                vm.Video_Optimize_SelectedItem = "Web";
                vm.Video_Scale_SelectedItem = "Source";
                vm.Video_ScalingAlgorithm_SelectedItem = "auto";
                vm.Video_AspectRatio_SelectedItem = "auto";

                // Subtitle
                vm.Subtitle_Codec_SelectedItem = "None";
                vm.Subtitle_Stream_SelectedItem = "none";

                // Audio
                vm.Audio_Codec_SelectedItem = "Vorbis";
                vm.Audio_Stream_SelectedItem = "1";
                vm.Audio_Channel_SelectedItem = "Stereo";
                vm.Audio_Quality_SelectedItem = "192";
                vm.Audio_VBR_IsChecked = true;
                vm.Audio_CompressionLevel_SelectedItem = "auto";
                vm.Audio_SampleRate_SelectedItem = "44.1k";
                vm.Audio_BitDepth_SelectedItem = "auto";
                vm.Audio_Volume_Text = "100";
                vm.Audio_HardLimiter_Value = 1;

                // Filters
                vm.FiltersSetDefault();
            }

            // -------------------------
            // YouTube
            // -------------------------
            else if (vm.Preset_SelectedItem == "YouTube")
            {
                //vm.Preset.IsEditable = false;

                // Format
                vm.Format_Container_SelectedItem = "mp4";
                vm.Format_Cut_SelectedItem = "No";
                vm.Format_CutStart_Hours_Text = "00";
                vm.Format_CutStart_Minutes_Text = "00";
                vm.Format_CutStart_Seconds_Text = "00";
                vm.Format_CutStart_Milliseconds_Text = "000";
                vm.Format_CutEnd_Hours_Text = "00";
                vm.Format_CutEnd_Minutes_Text = "00";
                vm.Format_CutEnd_Seconds_Text = "00";
                vm.Format_CutEnd_Milliseconds_Text = "000";

                // Video
                vm.Video_Codec_SelectedItem = "x264";
                vm.Video_EncodeSpeed_SelectedItem = "Medium";
                vm.Video_Quality_SelectedItem = "Ultra";
                vm.Video_Pass_SelectedItem = "CRF";
                vm.Video_Bitrate_Text = "";
                vm.Video_Minrate_Text = "";
                vm.Video_Maxrate_Text = "";
                vm.Video_Bufsize_Text = "";
                vm.Video_PixelFormat_SelectedItem = "yuv420p";
                vm.Video_FPS_SelectedItem = "auto";
                vm.Video_Optimize_SelectedItem = "Web";
                vm.Video_Scale_SelectedItem = "Source";
                vm.Video_ScalingAlgorithm_SelectedItem = "auto";
                vm.Video_AspectRatio_SelectedItem = "auto";

                // Subtitle
                vm.Subtitle_Codec_SelectedItem = "MOV Text";
                vm.Subtitle_Stream_SelectedItem = "all";

                // Audio
                vm.Audio_Codec_SelectedItem = "AAC";
                vm.Audio_Stream_SelectedItem = "all";
                vm.Audio_Channel_SelectedItem = "Source";
                vm.Audio_Quality_SelectedItem = "Auto";
                vm.Audio_VBR_IsChecked = false;
                vm.Audio_CompressionLevel_SelectedItem = "auto";
                vm.Audio_SampleRate_SelectedItem = "auto";
                vm.Audio_BitDepth_SelectedItem = "auto";
                vm.Audio_Volume_Text = "100";
                vm.Audio_HardLimiter_Value = 1;

                // Filters
                vm.FiltersSetDefault();
            }


            // ---------------------------------------------------------------------------
            // PC
            // ---------------------------------------------------------------------------
            // -------------------------
            // Archive Video
            // -------------------------
            else if (vm.Preset_SelectedItem == "Archive")
            {
                //vm.Preset.IsEditable = false;

                // Format
                vm.Format_Container_SelectedItem = "mkv";
                vm.Format_Cut_SelectedItem = "No";
                vm.Format_CutStart_Hours_Text = "00";
                vm.Format_CutStart_Minutes_Text = "00";
                vm.Format_CutStart_Seconds_Text = "00";
                vm.Format_CutStart_Milliseconds_Text = "000";
                vm.Format_CutEnd_Hours_Text = "00";
                vm.Format_CutEnd_Minutes_Text = "00";
                vm.Format_CutEnd_Seconds_Text = "00";
                vm.Format_CutEnd_Milliseconds_Text = "000";

                // Video
                vm.Video_Codec_SelectedItem = "FFV1";
                vm.Video_EncodeSpeed_SelectedItem = "None";
                vm.Video_Quality_SelectedItem = "Lossless";
                vm.Video_Pass_SelectedItem = "2 Pass";
                vm.Video_Bitrate_Text = "";
                vm.Video_Minrate_Text = "";
                vm.Video_Maxrate_Text = "";
                vm.Video_Bufsize_Text = "";
                vm.Video_PixelFormat_SelectedItem = "yuv444p10le";
                vm.Video_FPS_SelectedItem = "auto";
                vm.Video_Optimize_SelectedItem = "None";
                vm.Video_Scale_SelectedItem = "Source";
                vm.Video_ScalingAlgorithm_SelectedItem = "auto";
                vm.Video_AspectRatio_SelectedItem = "auto";

                // Subtitle
                vm.Subtitle_Codec_SelectedItem = "Copy";
                vm.Subtitle_Stream_SelectedItem = "all";

                // Audio
                vm.Audio_Codec_SelectedItem = "FLAC";
                vm.Audio_Stream_SelectedItem = "all";
                vm.Audio_Channel_SelectedItem = "Source";
                vm.Audio_Quality_SelectedItem = "Auto";
                vm.Audio_VBR_IsChecked = false;
                vm.Audio_CompressionLevel_SelectedItem = "auto";
                vm.Audio_SampleRate_SelectedItem = "auto";
                vm.Audio_BitDepth_SelectedItem = "auto";
                vm.Audio_Volume_Text = "100";
                vm.Audio_HardLimiter_Value = 1;

                // Filters
                vm.FiltersSetDefault();
            }

            // -------------------------
            // HEVC
            // -------------------------
            else if (vm.Preset_SelectedItem == "HEVC")
            {
                //vm.Preset.IsEditable = false;

                // Format
                vm.Format_Container_SelectedItem = "mkv";
                vm.Format_Cut_SelectedItem = "No";
                vm.Format_CutStart_Hours_Text = "00";
                vm.Format_CutStart_Minutes_Text = "00";
                vm.Format_CutStart_Seconds_Text = "00";
                vm.Format_CutStart_Milliseconds_Text = "000";
                vm.Format_CutEnd_Hours_Text = "00";
                vm.Format_CutEnd_Minutes_Text = "00";
                vm.Format_CutEnd_Seconds_Text = "00";
                vm.Format_CutEnd_Milliseconds_Text = "000";

                // Video
                vm.Video_Codec_SelectedItem = "x265";
                vm.Video_EncodeSpeed_SelectedItem = "Slow";
                vm.Video_Quality_SelectedItem = "Ultra";
                vm.Video_Pass_SelectedItem = "CRF";
                //vm.Video_CRF_Text = "18";
                vm.Video_Bitrate_Text = "";
                vm.Video_Minrate_Text = "";
                vm.Video_Maxrate_Text = "";
                vm.Video_Bufsize_Text = "";
                vm.Video_PixelFormat_SelectedItem = "yuv420p10le";
                vm.Video_FPS_SelectedItem = "auto";
                vm.Video_Optimize_SelectedItem = "Custom";
                vm.Video_Optimize_Tune_SelectedItem = "none";
                vm.Video_Optimize_Profile_SelectedItem = "main10";
                vm.Video_Optimize_Level_SelectedItem = "5.2";
                vm.Video_Scale_SelectedItem = "Source";
                vm.Video_ScalingAlgorithm_SelectedItem = "auto";
                vm.Video_AspectRatio_SelectedItem = "auto";


                // Subtitle
                vm.Subtitle_Codec_SelectedItem = "Copy";
                vm.Subtitle_Stream_SelectedItem = "all";

                // Audio
                vm.Audio_Codec_SelectedItem = "AAC";
                vm.Audio_Stream_SelectedItem = "all";
                vm.Audio_Channel_SelectedItem = "Source";
                vm.Audio_Quality_SelectedItem = "Auto";
                vm.Audio_VBR_IsChecked = false;
                vm.Audio_CompressionLevel_SelectedItem = "auto";
                vm.Audio_SampleRate_SelectedItem = "auto";
                vm.Audio_BitDepth_SelectedItem = "auto";
                vm.Audio_Volume_Text = "100";
                vm.Audio_HardLimiter_Value = 1;

                // Filters
                vm.FiltersSetDefault();
            }

            // -------------------------
            // HD Video
            // -------------------------
            else if (vm.Preset_SelectedItem == "HD Ultra" ||
                     vm.Preset_SelectedItem == "HD High" ||
                     vm.Preset_SelectedItem == "HD Medium" ||
                     vm.Preset_SelectedItem == "HD Low"
                     )
            {
                //vm.Preset.IsEditable = false;

                // Format
                vm.Format_Container_SelectedItem = "mp4";
                vm.Format_Cut_SelectedItem = "No";
                vm.Format_CutStart_Hours_Text = "00";
                vm.Format_CutStart_Minutes_Text = "00";
                vm.Format_CutStart_Seconds_Text = "00";
                vm.Format_CutStart_Milliseconds_Text = "000";
                vm.Format_CutEnd_Hours_Text = "00";
                vm.Format_CutEnd_Minutes_Text = "00";
                vm.Format_CutEnd_Seconds_Text = "00";
                vm.Format_CutEnd_Milliseconds_Text = "000";

                // Video
                vm.Video_Codec_SelectedItem = "x264";
                vm.Video_EncodeSpeed_SelectedItem = "Medium";

                if (vm.Preset_SelectedItem == "HD Ultra")
                {
                    vm.Video_Quality_SelectedItem = "Ultra";
                }
                else if (vm.Preset_SelectedItem == "HD High")
                {
                    vm.Video_Quality_SelectedItem = "High";
                }
                else if (vm.Preset_SelectedItem == "HD Medium")
                {
                    vm.Video_Quality_SelectedItem = "Medium";
                }
                else if (vm.Preset_SelectedItem == "HD Low")
                {
                    vm.Video_Quality_SelectedItem = "Low";
                }

                vm.Video_Pass_SelectedItem = "CRF";
                vm.Video_Bitrate_Text = "";
                vm.Video_Minrate_Text = "";
                vm.Video_Maxrate_Text = "";
                vm.Video_Bufsize_Text = "";
                vm.Video_PixelFormat_SelectedItem = "yuv420p";
                vm.Video_FPS_SelectedItem = "auto";
                vm.Video_Optimize_SelectedItem = "PC HD";
                vm.Video_Scale_SelectedItem = "Source";
                vm.Video_ScalingAlgorithm_SelectedItem = "auto";
                vm.Video_AspectRatio_SelectedItem = "auto";

                // Subtitle
                vm.Subtitle_Codec_SelectedItem = "MOV Text";
                vm.Subtitle_Stream_SelectedItem = "all";

                // Audio
                vm.Audio_Codec_SelectedItem = "AAC";
                vm.Audio_Stream_SelectedItem = "all";
                vm.Audio_Channel_SelectedItem = "Source";
                vm.Audio_Quality_SelectedItem = "Auto";
                vm.Audio_VBR_IsChecked = false;
                vm.Audio_CompressionLevel_SelectedItem = "auto";
                vm.Audio_SampleRate_SelectedItem = "auto";
                vm.Audio_BitDepth_SelectedItem = "auto";
                vm.Audio_Volume_Text = "100";
                vm.Audio_HardLimiter_Value = 1;

                // Filters
                vm.FiltersSetDefault();
            }

            // -------------------------
            // SD Video
            // -------------------------
            else if (vm.Preset_SelectedItem == "SD High" ||
                     vm.Preset_SelectedItem == "SD Medium" ||
                     vm.Preset_SelectedItem == "SD Low")
            {
                //vm.Preset.IsEditable = false;

                // Format
                vm.Format_Container_SelectedItem = "mp4";
                vm.Format_Cut_SelectedItem = "No";
                vm.Format_CutStart_Hours_Text = "00";
                vm.Format_CutStart_Minutes_Text = "00";
                vm.Format_CutStart_Seconds_Text = "00";
                vm.Format_CutStart_Milliseconds_Text = "000";
                vm.Format_CutEnd_Hours_Text = "00";
                vm.Format_CutEnd_Minutes_Text = "00";
                vm.Format_CutEnd_Seconds_Text = "00";
                vm.Format_CutEnd_Milliseconds_Text = "000";

                // Video
                vm.Video_Codec_SelectedItem = "x264";
                vm.Video_EncodeSpeed_SelectedItem = "Medium";

                if (vm.Preset_SelectedItem == "SD High")
                {
                    vm.Video_Quality_SelectedItem = "High";
                }
                else if (vm.Preset_SelectedItem == "SD Medium")
                {
                    vm.Video_Quality_SelectedItem = "Medium";
                }
                else if (vm.Preset_SelectedItem == "SD Low")
                {
                    vm.Video_Quality_SelectedItem = "Low";
                }

                vm.Video_Pass_SelectedItem = "CRF";
                vm.Video_Bitrate_Text = "";
                vm.Video_Minrate_Text = "";
                vm.Video_Maxrate_Text = "";
                vm.Video_Bufsize_Text = "";
                vm.Video_PixelFormat_SelectedItem = "yuv420p";
                vm.Video_FPS_SelectedItem = "auto";
                vm.Video_Optimize_SelectedItem = "PC SD";
                vm.Video_Scale_SelectedItem = "Source";
                vm.Video_ScalingAlgorithm_SelectedItem = "auto";
                vm.Video_AspectRatio_SelectedItem = "auto";

                // Subtitle
                vm.Subtitle_Codec_SelectedItem = "MOV Text";
                vm.Subtitle_Stream_SelectedItem = "all";

                // Audio
                vm.Audio_Codec_SelectedItem = "AC3";
                vm.Audio_Stream_SelectedItem = "all";
                vm.Audio_Channel_SelectedItem = "Stereo";
                vm.Audio_Quality_SelectedItem = "256";
                vm.Audio_VBR_IsChecked = false;
                vm.Audio_CompressionLevel_SelectedItem = "auto";
                vm.Audio_SampleRate_SelectedItem = "44.1k";
                vm.Audio_BitDepth_SelectedItem = "auto";
                vm.Audio_Volume_Text = "100";
                vm.Audio_HardLimiter_Value = 1;

                // Filters
                vm.FiltersSetDefault();
            }


            // ---------------------------------------------------------------------------
            // Device
            // ---------------------------------------------------------------------------
            // -------------------------
            // Roku
            // -------------------------
            else if (vm.Preset_SelectedItem == "Roku")
            {
                //vm.Preset.IsEditable = false;

                // Format
                vm.Format_Container_SelectedItem = "mkv";
                vm.Format_Cut_SelectedItem = "No";
                vm.Format_CutStart_Hours_Text = "00";
                vm.Format_CutStart_Minutes_Text = "00";
                vm.Format_CutStart_Seconds_Text = "00";
                vm.Format_CutStart_Milliseconds_Text = "000";
                vm.Format_CutEnd_Hours_Text = "00";
                vm.Format_CutEnd_Minutes_Text = "00";
                vm.Format_CutEnd_Seconds_Text = "00";
                vm.Format_CutEnd_Milliseconds_Text = "000";

                // Video
                vm.Video_Codec_SelectedItem = "x264";
                vm.Video_EncodeSpeed_SelectedItem = "Medium";
                vm.Video_Quality_SelectedItem = "Ultra";
                vm.Video_Pass_SelectedItem = "CRF";
                vm.Video_Bitrate_Text = "";
                vm.Video_Minrate_Text = "";
                vm.Video_Maxrate_Text = "";
                vm.Video_Bufsize_Text = "";
                vm.Video_PixelFormat_SelectedItem = "yuv420p";
                vm.Video_FPS_SelectedItem = "auto";
                vm.Video_Optimize_SelectedItem = "Custom";
                vm.Video_Optimize_Tune_SelectedItem = "none";
                vm.Video_Optimize_Profile_SelectedItem = "high";
                vm.Video_Optimize_Level_SelectedItem = "4.0";
                vm.Video_Scale_SelectedItem = "Source";
                vm.Video_ScalingAlgorithm_SelectedItem = "auto";
                vm.Video_AspectRatio_SelectedItem = "auto";

                // Subtitle
                vm.Subtitle_Codec_SelectedItem = "SRT";
                vm.Subtitle_Stream_SelectedItem = "all";

                // Audio
                vm.Audio_Codec_SelectedItem = "AAC";
                vm.Audio_Stream_SelectedItem = "all";
                vm.Audio_Channel_SelectedItem = "Source";
                vm.Audio_Quality_SelectedItem = "160";
                vm.Audio_VBR_IsChecked = false;
                vm.Audio_CompressionLevel_SelectedItem = "auto";
                vm.Audio_SampleRate_SelectedItem = "auto";
                vm.Audio_BitDepth_SelectedItem = "auto";
                vm.Audio_Volume_Text = "100";
                vm.Audio_HardLimiter_Value = 1;

                // Filters
                vm.FiltersSetDefault();
            }

            // -------------------------
            // Amazon Fire
            // -------------------------
            else if (vm.Preset_SelectedItem == "Amazon Fire")
            {
                //vm.Preset.IsEditable = false;

                // Format
                vm.Format_Container_SelectedItem = "mp4";
                vm.Format_Cut_SelectedItem = "No";
                vm.Format_CutStart_Hours_Text = "00";
                vm.Format_CutStart_Minutes_Text = "00";
                vm.Format_CutStart_Seconds_Text = "00";
                vm.Format_CutStart_Milliseconds_Text = "000";
                vm.Format_CutEnd_Hours_Text = "00";
                vm.Format_CutEnd_Minutes_Text = "00";
                vm.Format_CutEnd_Seconds_Text = "00";
                vm.Format_CutEnd_Milliseconds_Text = "000";

                // Video
                vm.Video_Codec_SelectedItem = "x264";
                vm.Video_EncodeSpeed_SelectedItem = "Medium";
                vm.Video_Quality_SelectedItem = "Ultra";
                vm.Video_Pass_SelectedItem = "CRF";
                vm.Video_Bitrate_Text = "";
                vm.Video_Minrate_Text = "";
                vm.Video_Maxrate_Text = "";
                vm.Video_Bufsize_Text = "";
                vm.Video_PixelFormat_SelectedItem = "yuv420p";
                vm.Video_FPS_SelectedItem = "auto";
                vm.Video_Optimize_SelectedItem = "Custom";
                vm.Video_Optimize_Tune_SelectedItem = "none";
                vm.Video_Optimize_Profile_SelectedItem = "high";
                vm.Video_Optimize_Level_SelectedItem = "4.2";
                vm.Video_Scale_SelectedItem = "Source";
                vm.Video_ScalingAlgorithm_SelectedItem = "auto";
                vm.Video_AspectRatio_SelectedItem = "auto";

                // Subtitle
                vm.Subtitle_Codec_SelectedItem = "SRT";
                vm.Subtitle_Stream_SelectedItem = "all";

                // Audio
                vm.Audio_Codec_SelectedItem = "AAC";
                vm.Audio_Stream_SelectedItem = "all";
                vm.Audio_Channel_SelectedItem = "Source";
                vm.Audio_Quality_SelectedItem = "160";
                vm.Audio_VBR_IsChecked = false;
                vm.Audio_CompressionLevel_SelectedItem = "auto";
                vm.Audio_SampleRate_SelectedItem = "auto";
                vm.Audio_BitDepth_SelectedItem = "auto";
                vm.Audio_Volume_Text = "100";
                vm.Audio_HardLimiter_Value = 1;

                // Filters
                vm.FiltersSetDefault();
            }

            // -------------------------
            // Chromecast
            // -------------------------
            else if (vm.Preset_SelectedItem == "Chromecast")
            {
                //vm.Preset.IsEditable = false;

                // Format
                vm.Format_Container_SelectedItem = "mp4";
                vm.Format_Cut_SelectedItem = "No";
                vm.Format_CutStart_Hours_Text = "00";
                vm.Format_CutStart_Minutes_Text = "00";
                vm.Format_CutStart_Seconds_Text = "00";
                vm.Format_CutStart_Milliseconds_Text = "000";
                vm.Format_CutEnd_Hours_Text = "00";
                vm.Format_CutEnd_Minutes_Text = "00";
                vm.Format_CutEnd_Seconds_Text = "00";
                vm.Format_CutEnd_Milliseconds_Text = "000";

                // Video
                vm.Video_Codec_SelectedItem = "x264";
                vm.Video_EncodeSpeed_SelectedItem = "Medium";
                vm.Video_Quality_SelectedItem = "Ultra";
                vm.Video_Pass_SelectedItem = "CRF";
                vm.Video_Bitrate_Text = "";
                vm.Video_Minrate_Text = "";
                vm.Video_Maxrate_Text = "";
                vm.Video_Bufsize_Text = "";
                vm.Video_PixelFormat_SelectedItem = "yuv420p";
                vm.Video_FPS_SelectedItem = "auto";
                vm.Video_Optimize_SelectedItem = "Custom";
                vm.Video_Optimize_Tune_SelectedItem = "none";
                vm.Video_Optimize_Profile_SelectedItem = "high";
                vm.Video_Optimize_Level_SelectedItem = "4.2";
                vm.Video_Scale_SelectedItem = "Source";
                vm.Video_ScalingAlgorithm_SelectedItem = "auto";
                vm.Video_AspectRatio_SelectedItem = "auto";

                // Subtitle
                vm.Subtitle_Codec_SelectedItem = "SRT";
                vm.Subtitle_Stream_SelectedItem = "all";

                // Audio
                vm.Audio_Codec_SelectedItem = "AAC";
                vm.Audio_Stream_SelectedItem = "all";
                vm.Audio_Channel_SelectedItem = "Source";
                vm.Audio_Quality_SelectedItem = "160";
                vm.Audio_VBR_IsChecked = false;
                vm.Audio_CompressionLevel_SelectedItem = "auto";
                vm.Audio_SampleRate_SelectedItem = "auto";
                vm.Audio_BitDepth_SelectedItem = "auto";
                vm.Audio_Volume_Text = "100";
                vm.Audio_HardLimiter_Value = 1;

                // Filters
                vm.FiltersSetDefault();
            }

            // -------------------------
            // Apple TV
            // -------------------------
            else if (vm.Preset_SelectedItem == "Apple TV")
            {
                //vm.Preset.IsEditable = false;

                // Format
                vm.Format_Container_SelectedItem = "mp4";
                vm.Format_Cut_SelectedItem = "No";
                vm.Format_CutStart_Hours_Text = "00";
                vm.Format_CutStart_Minutes_Text = "00";
                vm.Format_CutStart_Seconds_Text = "00";
                vm.Format_CutStart_Milliseconds_Text = "000";
                vm.Format_CutEnd_Hours_Text = "00";
                vm.Format_CutEnd_Minutes_Text = "00";
                vm.Format_CutEnd_Seconds_Text = "00";
                vm.Format_CutEnd_Milliseconds_Text = "000";

                // Video
                vm.Video_Codec_SelectedItem = "x264";
                vm.Video_EncodeSpeed_SelectedItem = "Medium";
                vm.Video_Quality_SelectedItem = "Ultra";
                vm.Video_Pass_SelectedItem = "CRF";
                vm.Video_Bitrate_Text = "";
                vm.Video_Minrate_Text = "";
                vm.Video_Maxrate_Text = "";
                vm.Video_Bufsize_Text = "";
                vm.Video_PixelFormat_SelectedItem = "yuv420p";
                vm.Video_FPS_SelectedItem = "auto";
                vm.Video_Optimize_SelectedItem = "Custom";
                vm.Video_Optimize_Tune_SelectedItem = "none";
                vm.Video_Optimize_Profile_SelectedItem = "high";
                vm.Video_Optimize_Level_SelectedItem = "4.2";
                vm.Video_Scale_SelectedItem = "Source";
                vm.Video_ScalingAlgorithm_SelectedItem = "auto";
                vm.Video_AspectRatio_SelectedItem = "auto";

                // Subtitle
                vm.Subtitle_Codec_SelectedItem = "SRT";
                vm.Subtitle_Stream_SelectedItem = "all";

                // Audio
                vm.Audio_Codec_SelectedItem = "AAC";
                vm.Audio_Stream_SelectedItem = "all";
                vm.Audio_Channel_SelectedItem = "Source";
                vm.Audio_Quality_SelectedItem = "160";
                vm.Audio_VBR_IsChecked = false;
                vm.Audio_CompressionLevel_SelectedItem = "auto";
                vm.Audio_SampleRate_SelectedItem = "auto";
                vm.Audio_BitDepth_SelectedItem = "auto";
                vm.Audio_Volume_Text = "100";
                vm.Audio_HardLimiter_Value = 1;

                // Filters
                vm.FiltersSetDefault();
            }

            // -------------------------
            // Raspberry Pi
            // -------------------------
            else if (vm.Preset_SelectedItem == "Raspberry Pi")
            {
                //vm.Preset.IsEditable = false;

                // Format
                vm.Format_Container_SelectedItem = "mp4";
                vm.Format_Cut_SelectedItem = "No";
                vm.Format_CutStart_Hours_Text = "00";
                vm.Format_CutStart_Minutes_Text = "00";
                vm.Format_CutStart_Seconds_Text = "00";
                vm.Format_CutStart_Milliseconds_Text = "000";
                vm.Format_CutEnd_Hours_Text = "00";
                vm.Format_CutEnd_Minutes_Text = "00";
                vm.Format_CutEnd_Seconds_Text = "00";
                vm.Format_CutEnd_Milliseconds_Text = "000";

                // Video
                vm.Video_Codec_SelectedItem = "x264";
                vm.Video_EncodeSpeed_SelectedItem = "Medium";
                vm.Video_Quality_SelectedItem = "High";
                vm.Video_Pass_SelectedItem = "CRF";
                vm.Video_Bitrate_Text = "";
                vm.Video_Minrate_Text = "";
                vm.Video_Maxrate_Text = "";
                vm.Video_Bufsize_Text = "";
                vm.Video_PixelFormat_SelectedItem = "yuv420p";
                vm.Video_FPS_SelectedItem = "auto";
                vm.Video_Optimize_SelectedItem = "Custom";
                vm.Video_Optimize_Tune_SelectedItem = "none";
                vm.Video_Optimize_Profile_SelectedItem = "main";
                vm.Video_Optimize_Level_SelectedItem = "4.2";
                vm.Video_Scale_SelectedItem = "Source";
                vm.Video_ScalingAlgorithm_SelectedItem = "auto";
                vm.Video_AspectRatio_SelectedItem = "auto";

                // Subtitle
                vm.Subtitle_Codec_SelectedItem = "SRT";
                vm.Subtitle_Stream_SelectedItem = "all";

                // Audio
                vm.Audio_Codec_SelectedItem = "AAC";
                vm.Audio_Stream_SelectedItem = "all";
                vm.Audio_Channel_SelectedItem = "Source";
                vm.Audio_Quality_SelectedItem = "160";
                vm.Audio_VBR_IsChecked = false;
                vm.Audio_CompressionLevel_SelectedItem = "auto";
                vm.Audio_SampleRate_SelectedItem = "auto";
                vm.Audio_BitDepth_SelectedItem = "auto";
                vm.Audio_Volume_Text = "100";
                vm.Audio_HardLimiter_Value = 1;

                // Filters
                vm.FiltersSetDefault();
            }


            // ---------------------------------------------------------------------------
            // Mobile
            // ---------------------------------------------------------------------------
            // -------------------------
            // Android
            // -------------------------
            else if (vm.Preset_SelectedItem == "Android")
            {
                //vm.Preset.IsEditable = false;

                // Format
                vm.Format_Container_SelectedItem = "mp4";
                vm.Format_Cut_SelectedItem = "No";
                vm.Format_CutStart_Hours_Text = "00";
                vm.Format_CutStart_Minutes_Text = "00";
                vm.Format_CutStart_Seconds_Text = "00";
                vm.Format_CutStart_Milliseconds_Text = "000";
                vm.Format_CutEnd_Hours_Text = "00";
                vm.Format_CutEnd_Minutes_Text = "00";
                vm.Format_CutEnd_Seconds_Text = "00";
                vm.Format_CutEnd_Milliseconds_Text = "000";

                // Video
                vm.Video_Codec_SelectedItem = "x264";
                vm.Video_EncodeSpeed_SelectedItem = "Medium";
                vm.Video_Quality_SelectedItem = "High";
                vm.Video_Pass_SelectedItem = "CRF";
                vm.Video_Bitrate_Text = "";
                vm.Video_Minrate_Text = "";
                vm.Video_Maxrate_Text = "";
                vm.Video_Bufsize_Text = "";
                vm.Video_PixelFormat_SelectedItem = "yuv420p";
                vm.Video_Optimize_SelectedItem = "Android";
                vm.Video_FPS_SelectedItem = "23.976";
                vm.Video_Scale_SelectedItem = "Source";
                vm.Video_ScalingAlgorithm_SelectedItem = "auto";
                vm.Video_AspectRatio_SelectedItem = "auto";

                // Subtitle
                vm.Subtitle_Codec_SelectedItem = "MOV Text";
                vm.Subtitle_Stream_SelectedItem = "all";

                // Audio
                vm.Audio_Codec_SelectedItem = "AAC";
                vm.Audio_Stream_SelectedItem = "all";
                vm.Audio_Channel_SelectedItem = "Stereo";
                vm.Audio_Quality_SelectedItem = "400";
                vm.Audio_VBR_IsChecked = true;
                vm.Audio_CompressionLevel_SelectedItem = "auto";
                vm.Audio_SampleRate_SelectedItem = "44.1k";
                vm.Audio_BitDepth_SelectedItem = "auto";
                vm.Audio_Volume_Text = "100";
                vm.Audio_HardLimiter_Value = 1;

                // Filters
                vm.FiltersSetDefault();
            }

            // -------------------------
            // iOS
            // -------------------------
            else if (vm.Preset_SelectedItem == "iOS")
            {
                //vm.Preset.IsEditable = false;

                // Format
                vm.Format_Container_SelectedItem = "mp4";
                vm.Format_Cut_SelectedItem = "No";
                vm.Format_CutStart_Hours_Text = "00";
                vm.Format_CutStart_Minutes_Text = "00";
                vm.Format_CutStart_Seconds_Text = "00";
                vm.Format_CutStart_Milliseconds_Text = "000";
                vm.Format_CutEnd_Hours_Text = "00";
                vm.Format_CutEnd_Minutes_Text = "00";
                vm.Format_CutEnd_Seconds_Text = "00";
                vm.Format_CutEnd_Milliseconds_Text = "000";

                // Video
                vm.Video_Codec_SelectedItem = "x264";
                vm.Video_EncodeSpeed_SelectedItem = "Medium";
                vm.Video_Quality_SelectedItem = "High";
                vm.Video_Pass_SelectedItem = "CRF";
                vm.Video_Bitrate_Text = "";
                vm.Video_Minrate_Text = "";
                vm.Video_Maxrate_Text = "";
                vm.Video_Bufsize_Text = "";
                vm.Video_PixelFormat_SelectedItem = "yuv420p";
                vm.Video_FPS_SelectedItem = "23.976";
                vm.Video_Optimize_SelectedItem = "Apple";
                vm.Video_Scale_SelectedItem = "Source";
                vm.Video_ScalingAlgorithm_SelectedItem = "auto";
                vm.Video_AspectRatio_SelectedItem = "auto";

                // Subtitle
                vm.Subtitle_Codec_SelectedItem = "MOV Text";
                vm.Subtitle_Stream_SelectedItem = "all";

                // Audio
                vm.Audio_Codec_SelectedItem = "AAC";
                vm.Audio_Stream_SelectedItem = "all";
                vm.Audio_Channel_SelectedItem = "Stereo";
                vm.Audio_Quality_SelectedItem = "400";
                vm.Audio_VBR_IsChecked = true;
                vm.Audio_CompressionLevel_SelectedItem = "auto";
                vm.Audio_SampleRate_SelectedItem = "44.1k";
                vm.Audio_BitDepth_SelectedItem = "auto";
                vm.Audio_Volume_Text = "100";
                vm.Audio_HardLimiter_Value = 1;

                // Filters
                vm.FiltersSetDefault();
            }


            // ---------------------------------------------------------------------------
            // Console
            // ---------------------------------------------------------------------------
            // -------------------------
            // PS3
            // -------------------------
            else if (vm.Preset_SelectedItem == "PS3")
            {
                //vm.Preset.IsEditable = false;

                // Format
                vm.Format_Container_SelectedItem = "mp4";
                vm.Format_Cut_SelectedItem = "No";
                vm.Format_CutStart_Hours_Text = "00";
                vm.Format_CutStart_Minutes_Text = "00";
                vm.Format_CutStart_Seconds_Text = "00";
                vm.Format_CutStart_Milliseconds_Text = "000";
                vm.Format_CutEnd_Hours_Text = "00";
                vm.Format_CutEnd_Minutes_Text = "00";
                vm.Format_CutEnd_Seconds_Text = "00";
                vm.Format_CutEnd_Milliseconds_Text = "000";

                // Video
                vm.Video_Codec_SelectedItem = "x264";
                vm.Video_EncodeSpeed_SelectedItem = "Medium";
                vm.Video_Quality_SelectedItem = "Ultra";
                vm.Video_Pass_SelectedItem = "CRF";
                vm.Video_Bitrate_Text = "";
                vm.Video_Minrate_Text = "";
                vm.Video_Maxrate_Text = "";
                vm.Video_Bufsize_Text = "";
                vm.Video_PixelFormat_SelectedItem = "yuv420p";
                vm.Video_FPS_SelectedItem = "23.976";
                vm.Video_Optimize_SelectedItem = "PS3";
                vm.Video_Scale_SelectedItem = "Source";
                vm.Video_ScalingAlgorithm_SelectedItem = "auto";
                vm.Video_AspectRatio_SelectedItem = "auto";

                // Subtitle
                vm.Subtitle_Codec_SelectedItem = "MOV Text";
                vm.Subtitle_Stream_SelectedItem = "all";

                // Audio
                vm.Audio_Codec_SelectedItem = "AAC";
                vm.Audio_Stream_SelectedItem = "all";
                vm.Audio_Channel_SelectedItem = "Source";
                vm.Audio_Quality_SelectedItem = "400";
                vm.Audio_VBR_IsChecked = false;
                vm.Audio_CompressionLevel_SelectedItem = "auto";
                vm.Audio_SampleRate_SelectedItem = "48k";
                vm.Audio_BitDepth_SelectedItem = "auto";
                vm.Audio_Volume_Text = "100";
                vm.Audio_HardLimiter_Value = 1;

                // Filters
                vm.FiltersSetDefault();
            }

            // -------------------------
            // PS4
            // -------------------------
            else if (vm.Preset_SelectedItem == "PS4")
            {
                //vm.Preset.IsEditable = false;

                // Format
                vm.Format_Container_SelectedItem = "mp4";
                vm.Format_Cut_SelectedItem = "No";
                vm.Format_CutStart_Hours_Text = "00";
                vm.Format_CutStart_Minutes_Text = "00";
                vm.Format_CutStart_Seconds_Text = "00";
                vm.Format_CutStart_Milliseconds_Text = "000";
                vm.Format_CutEnd_Hours_Text = "00";
                vm.Format_CutEnd_Minutes_Text = "00";
                vm.Format_CutEnd_Seconds_Text = "00";
                vm.Format_CutEnd_Milliseconds_Text = "000";

                // Video
                vm.Video_Codec_SelectedItem = "x264";
                vm.Video_EncodeSpeed_SelectedItem = "Medium";
                vm.Video_Quality_SelectedItem = "Ultra";
                vm.Video_Pass_SelectedItem = "CRF";
                vm.Video_Bitrate_Text = "";
                vm.Video_Minrate_Text = "";
                vm.Video_Maxrate_Text = "";
                vm.Video_Bufsize_Text = "";
                vm.Video_PixelFormat_SelectedItem = "yuv420p";
                vm.Video_FPS_SelectedItem = "auto";
                vm.Video_Optimize_SelectedItem = "PS4";
                vm.Video_Scale_SelectedItem = "Source";
                vm.Video_ScalingAlgorithm_SelectedItem = "auto";
                vm.Video_AspectRatio_SelectedItem = "auto";

                // Subtitle
                vm.Subtitle_Codec_SelectedItem = "MOV Text";
                vm.Subtitle_Stream_SelectedItem = "all";

                // Audio
                vm.Audio_Codec_SelectedItem = "AAC";
                vm.Audio_Stream_SelectedItem = "all";
                vm.Audio_Channel_SelectedItem = "Source";
                vm.Audio_Quality_SelectedItem = "Auto";
                vm.Audio_SampleRate_SelectedItem = "auto";
                vm.Audio_BitDepth_SelectedItem = "auto";
                vm.Audio_VBR_IsChecked = false;
                vm.Audio_CompressionLevel_SelectedItem = "auto";
                vm.Audio_Volume_Text = "100";
                vm.Audio_HardLimiter_Value = 1;

                // Filters
                vm.FiltersSetDefault();
            }

            // -------------------------
            // Xbox 360
            // -------------------------
            else if (vm.Preset_SelectedItem == "Xbox 360")
            {
                //vm.Preset.IsEditable = false;

                // Format
                vm.Format_Container_SelectedItem = "mp4";
                vm.Format_Cut_SelectedItem = "No";
                vm.Format_CutStart_Hours_Text = "00";
                vm.Format_CutStart_Minutes_Text = "00";
                vm.Format_CutStart_Seconds_Text = "00";
                vm.Format_CutStart_Milliseconds_Text = "000";
                vm.Format_CutEnd_Hours_Text = "00";
                vm.Format_CutEnd_Minutes_Text = "00";
                vm.Format_CutEnd_Seconds_Text = "00";
                vm.Format_CutEnd_Milliseconds_Text = "000";

                // Video
                vm.Video_Codec_SelectedItem = "x264";
                vm.Video_EncodeSpeed_SelectedItem = "Medium";
                vm.Video_Quality_SelectedItem = "High";
                vm.Video_Pass_SelectedItem = "CRF";
                vm.Video_Bitrate_Text = "";
                vm.Video_Minrate_Text = "";
                vm.Video_Maxrate_Text = "";
                vm.Video_Bufsize_Text = "";
                vm.Video_PixelFormat_SelectedItem = "yuv420p";
                vm.Video_FPS_SelectedItem = "23.976";
                vm.Video_Optimize_SelectedItem = "Xbox 360";
                vm.Video_Scale_SelectedItem = "Source";
                vm.Video_ScalingAlgorithm_SelectedItem = "auto";
                vm.Video_AspectRatio_SelectedItem = "auto";

                // Subtitle
                vm.Subtitle_Codec_SelectedItem = "MOV Text";
                vm.Subtitle_Stream_SelectedItem = "all";

                // Audio
                vm.Audio_Codec_SelectedItem = "AAC";
                vm.Audio_Stream_SelectedItem = "all";
                vm.Audio_Channel_SelectedItem = "Stereo";
                vm.Audio_Quality_SelectedItem = "320";
                vm.Audio_SampleRate_SelectedItem = "48k";
                vm.Audio_BitDepth_SelectedItem = "auto";
                vm.Audio_VBR_IsChecked = false;
                vm.Audio_CompressionLevel_SelectedItem = "auto";
                vm.Audio_Volume_Text = "100";
                vm.Audio_HardLimiter_Value = 1;

                // Filters
                vm.FiltersSetDefault();
            }

            // -------------------------
            // Xbox One
            // -------------------------
            else if (vm.Preset_SelectedItem == "Xbox One")
            {
                //vm.Preset.IsEditable = false;

                // Format
                vm.Format_Container_SelectedItem = "mp4";
                vm.Format_Cut_SelectedItem = "No";
                vm.Format_CutStart_Hours_Text = "00";
                vm.Format_CutStart_Minutes_Text = "00";
                vm.Format_CutStart_Seconds_Text = "00";
                vm.Format_CutStart_Milliseconds_Text = "000";
                vm.Format_CutEnd_Hours_Text = "00";
                vm.Format_CutEnd_Minutes_Text = "00";
                vm.Format_CutEnd_Seconds_Text = "00";
                vm.Format_CutEnd_Milliseconds_Text = "000";

                // Video
                vm.Video_Codec_SelectedItem = "x264";
                vm.Video_EncodeSpeed_SelectedItem = "Medium";
                vm.Video_Quality_SelectedItem = "Ultra";
                vm.Video_Pass_SelectedItem = "CRF";
                vm.Video_Bitrate_Text = "";
                vm.Video_Minrate_Text = "";
                vm.Video_Maxrate_Text = "";
                vm.Video_Bufsize_Text = "";
                vm.Video_PixelFormat_SelectedItem = "yuv420p";
                vm.Video_FPS_SelectedItem = "auto";
                vm.Video_Optimize_SelectedItem = "Xbox One";
                vm.Video_Scale_SelectedItem = "Source";
                vm.Video_ScalingAlgorithm_SelectedItem = "auto";
                vm.Video_AspectRatio_SelectedItem = "auto";

                // Subtitle
                vm.Subtitle_Codec_SelectedItem = "MOV Text";
                vm.Subtitle_Stream_SelectedItem = "all";

                // Audio
                vm.Audio_Codec_SelectedItem = "AAC";
                vm.Audio_Stream_SelectedItem = "all";
                vm.Audio_Channel_SelectedItem = "Source";
                vm.Audio_Quality_SelectedItem = "Auto";
                vm.Audio_SampleRate_SelectedItem = "auto";
                vm.Audio_BitDepth_SelectedItem = "auto";
                vm.Audio_VBR_IsChecked = false;
                vm.Audio_CompressionLevel_SelectedItem = "auto";
                vm.Audio_Volume_Text = "100";
                vm.Audio_HardLimiter_Value = 1;

                // Filters
                vm.FiltersSetDefault();
            }


            // ---------------------------------------------------------------------------
            // Disc
            // ---------------------------------------------------------------------------
            // -------------------------
            // UHD
            // -------------------------
            else if (vm.Preset_SelectedItem == "UHD")
            {
                //vm.Preset.IsEditable = false;

                // Format
                vm.Format_Container_SelectedItem = "mp4";
                vm.Format_Cut_SelectedItem = "No";
                vm.Format_CutStart_Hours_Text = "00";
                vm.Format_CutStart_Minutes_Text = "00";
                vm.Format_CutStart_Seconds_Text = "00";
                vm.Format_CutStart_Milliseconds_Text = "000";
                vm.Format_CutEnd_Hours_Text = "00";
                vm.Format_CutEnd_Minutes_Text = "00";
                vm.Format_CutEnd_Seconds_Text = "00";
                vm.Format_CutEnd_Milliseconds_Text = "000";

                // Video
                vm.Video_Codec_SelectedItem = "x265";
                vm.Video_EncodeSpeed_SelectedItem = "Slow";
                vm.Video_Quality_SelectedItem = "Custom";
                vm.Video_Pass_SelectedItem = "2 Pass";
                vm.Video_Bitrate_Text = "50M";
                vm.Video_Minrate_Text = "";
                vm.Video_Maxrate_Text = "75M";
                vm.Video_Bufsize_Text = "75M";
                vm.Video_PixelFormat_SelectedItem = "yuv420p10le";
                vm.Video_FPS_SelectedItem = "23.976";
                vm.Video_Optimize_SelectedItem = "UHD";
                vm.Video_Scale_SelectedItem = "Source";
                vm.Video_ScalingAlgorithm_SelectedItem = "auto";
                vm.Video_AspectRatio_SelectedItem = "auto";

                // Subtitle
                vm.Subtitle_Codec_SelectedItem = "MOV Text";
                vm.Subtitle_Stream_SelectedItem = "all";

                // Audio
                vm.Audio_Codec_SelectedItem = "AC3";
                vm.Audio_Stream_SelectedItem = "all";
                vm.Audio_Channel_SelectedItem = "Source";
                vm.Audio_Quality_SelectedItem = "Auto";
                vm.Audio_VBR_IsChecked = false;
                vm.Audio_CompressionLevel_SelectedItem = "auto";
                vm.Audio_SampleRate_SelectedItem = "48k";
                vm.Audio_BitDepth_SelectedItem = "auto";
                vm.Audio_Volume_Text = "100";
                vm.Audio_HardLimiter_Value = 1;

                // Filters
                vm.FiltersSetDefault();
            }

            // -------------------------
            // Blu-ray
            // -------------------------
            else if (vm.Preset_SelectedItem == "Blu-ray")
            {
                //vm.Preset.IsEditable = false;

                // Format
                vm.Format_Container_SelectedItem = "mp4";
                vm.Format_Cut_SelectedItem = "No";
                vm.Format_CutStart_Hours_Text = "00";
                vm.Format_CutStart_Minutes_Text = "00";
                vm.Format_CutStart_Seconds_Text = "00";
                vm.Format_CutStart_Milliseconds_Text = "000";
                vm.Format_CutEnd_Hours_Text = "00";
                vm.Format_CutEnd_Minutes_Text = "00";
                vm.Format_CutEnd_Seconds_Text = "00";
                vm.Format_CutEnd_Milliseconds_Text = "000";

                // Video
                vm.Video_Codec_SelectedItem = "x264";
                vm.Video_EncodeSpeed_SelectedItem = "Slow";
                vm.Video_Quality_SelectedItem = "Ultra";
                vm.Video_Pass_SelectedItem = "CRF";
                vm.Video_Bitrate_Text = "";
                vm.Video_Minrate_Text = "";
                vm.Video_Maxrate_Text = "";
                vm.Video_Bufsize_Text = "";
                vm.Video_PixelFormat_SelectedItem = "yuv420p10le";
                vm.Video_FPS_SelectedItem = "23.976";
                vm.Video_Optimize_SelectedItem = "Blu-ray";
                vm.Video_Scale_SelectedItem = "1080p";
                vm.Video_ScalingAlgorithm_SelectedItem = "auto";
                vm.Video_AspectRatio_SelectedItem = "auto";

                // Subtitle
                vm.Subtitle_Codec_SelectedItem = "MOV Text";
                vm.Subtitle_Stream_SelectedItem = "all";

                // Audio
                vm.Audio_Codec_SelectedItem = "AC3";
                vm.Audio_Stream_SelectedItem = "all";
                vm.Audio_Channel_SelectedItem = "Source";
                vm.Audio_Quality_SelectedItem = "Auto";
                vm.Audio_VBR_IsChecked = false;
                vm.Audio_CompressionLevel_SelectedItem = "auto";
                vm.Audio_SampleRate_SelectedItem = "48k";
                vm.Audio_BitDepth_SelectedItem = "auto";
                vm.Audio_Volume_Text = "100";
                vm.Audio_HardLimiter_Value = 1;

                // Filters
                vm.FiltersSetDefault();
            }

            // -------------------------
            // DVD
            // -------------------------
            else if (vm.Preset_SelectedItem == "DVD")
            {
                //vm.Preset.IsEditable = false;

                // Format
                vm.Format_Container_SelectedItem = "mpg";
                vm.Format_Cut_SelectedItem = "No";
                vm.Format_CutStart_Hours_Text = "00";
                vm.Format_CutStart_Minutes_Text = "00";
                vm.Format_CutStart_Seconds_Text = "00";
                vm.Format_CutStart_Milliseconds_Text = "000";
                vm.Format_CutEnd_Hours_Text = "00";
                vm.Format_CutEnd_Minutes_Text = "00";
                vm.Format_CutEnd_Seconds_Text = "00";
                vm.Format_CutEnd_Milliseconds_Text = "000";

                // Video
                vm.Video_Codec_SelectedItem = "MPEG-2";
                vm.Video_EncodeSpeed_SelectedItem = "None";
                vm.Video_Quality_SelectedItem = "Custom";
                vm.Video_Pass_SelectedItem = "2 Pass";
                vm.Video_Bitrate_Text = "3M";
                vm.Video_Minrate_Text = "";
                vm.Video_Maxrate_Text = "9.8M";
                vm.Video_Bufsize_Text = "9.8M";
                vm.Video_PixelFormat_SelectedItem = "yuv420p";
                vm.Video_FPS_SelectedItem = "ntsc";
                vm.Video_Optimize_SelectedItem = "None";
                vm.Video_Scale_SelectedItem = "Custom";
                vm.Video_Width_Text = "720";
                vm.Video_Height_Text = "auto";
                vm.Video_ScalingAlgorithm_SelectedItem = "auto";
                vm.Video_AspectRatio_SelectedItem = "auto";

                // Subtitle
                vm.Subtitle_Codec_SelectedItem = "SRT";
                vm.Subtitle_Stream_SelectedItem = "all";

                // Audio
                vm.Audio_Codec_SelectedItem = "MP2";
                vm.Audio_Stream_SelectedItem = "all";
                vm.Audio_Channel_SelectedItem = "Source";
                vm.Audio_Quality_SelectedItem = "320";
                vm.Audio_VBR_IsChecked = false;
                vm.Audio_CompressionLevel_SelectedItem = "auto";
                vm.Audio_SampleRate_SelectedItem = "44.1k";
                vm.Audio_BitDepth_SelectedItem = "auto";
                vm.Audio_Volume_Text = "100";
                vm.Audio_HardLimiter_Value = 1;

                // Filters
                vm.FiltersSetDefault();
            }


            // ---------------------------------------------------------------------------
            // Music
            // ---------------------------------------------------------------------------
            // -------------------------
            // Lossless
            // -------------------------
            else if (vm.Preset_SelectedItem == "Lossless")
            {
                //vm.Preset.IsEditable = false;

                // Format
                vm.Format_Container_SelectedItem = "flac";
                vm.Format_Cut_SelectedItem = "No";
                vm.Format_CutStart_Hours_Text = "00";
                vm.Format_CutStart_Minutes_Text = "00";
                vm.Format_CutStart_Seconds_Text = "00";
                vm.Format_CutStart_Milliseconds_Text = "000";
                vm.Format_CutEnd_Hours_Text = "00";
                vm.Format_CutEnd_Minutes_Text = "00";
                vm.Format_CutEnd_Seconds_Text = "00";
                vm.Format_CutEnd_Milliseconds_Text = "000";

                // Video
                vm.Video_Codec_SelectedItem = "None";
                vm.Video_EncodeSpeed_SelectedItem = "None";
                vm.Video_Quality_SelectedItem = "None";
                vm.Video_Pass_SelectedItem = "auto";
                vm.Video_Bitrate_Text = "";
                vm.Video_Minrate_Text = "";
                vm.Video_Maxrate_Text = "";
                vm.Video_Bufsize_Text = "";
                vm.Video_PixelFormat_SelectedItem = "none";
                vm.Video_FPS_SelectedItem = "auto";
                vm.Video_Optimize_SelectedItem = "None";
                vm.Video_Scale_SelectedItem = "Source";
                vm.Video_ScalingAlgorithm_SelectedItem = "auto";
                vm.Video_AspectRatio_SelectedItem = "auto";

                // Subtitle
                vm.Subtitle_Codec_SelectedItem = "None";
                vm.Subtitle_Stream_SelectedItem = "none";

                // Audio
                vm.Audio_Codec_SelectedItem = "FLAC";
                vm.Audio_Stream_SelectedItem = "1";
                vm.Audio_Channel_SelectedItem = "Source";
                vm.Audio_Quality_SelectedItem = "Lossless";
                vm.Audio_VBR_IsChecked = true;
                vm.Audio_CompressionLevel_SelectedItem = "auto";
                vm.Audio_SampleRate_SelectedItem = "auto";
                vm.Audio_BitDepth_SelectedItem = "auto";
                vm.Audio_Volume_Text = "100";
                vm.Audio_HardLimiter_Value = 1;

                // Filters
                vm.FiltersSetDefault();
            }

            // -------------------------
            // MP3
            // -------------------------
            else if (vm.Preset_SelectedItem == "MP3 HQ" ||
                     vm.Preset_SelectedItem == "MP3 Low")
            {
                //vm.Preset.IsEditable = false;

                // Format
                vm.Format_Container_SelectedItem = "mp3";
                vm.Format_Cut_SelectedItem = "No";
                vm.Format_CutStart_Hours_Text = "00";
                vm.Format_CutStart_Minutes_Text = "00";
                vm.Format_CutStart_Seconds_Text = "00";
                vm.Format_CutStart_Milliseconds_Text = "000";
                vm.Format_CutEnd_Hours_Text = "00";
                vm.Format_CutEnd_Minutes_Text = "00";
                vm.Format_CutEnd_Seconds_Text = "00";
                vm.Format_CutEnd_Milliseconds_Text = "000";

                // Video
                vm.Video_Codec_SelectedItem = "None";
                vm.Video_EncodeSpeed_SelectedItem = "None";
                vm.Video_Quality_SelectedItem = "None";
                vm.Video_Pass_SelectedItem = "auto";
                vm.Video_Bitrate_Text = "";
                vm.Video_Minrate_Text = "";
                vm.Video_Maxrate_Text = "";
                vm.Video_Bufsize_Text = "";
                vm.Video_PixelFormat_SelectedItem = "none";
                vm.Video_FPS_SelectedItem = "auto";
                vm.Video_Optimize_SelectedItem = "None";
                vm.Video_Scale_SelectedItem = "Source";
                vm.Video_ScalingAlgorithm_SelectedItem = "auto";
                vm.Video_AspectRatio_SelectedItem = "auto";

                // Subtitle
                vm.Subtitle_Codec_SelectedItem = "None";
                vm.Subtitle_Stream_SelectedItem = "none";

                // Audio
                vm.Audio_Codec_SelectedItem = "LAME";
                vm.Audio_Stream_SelectedItem = "1";
                vm.Audio_Channel_SelectedItem = "Joint Stereo";

                // HQ
                if (vm.Preset_SelectedItem == "MP3 HQ")
                {
                    vm.Audio_Quality_SelectedItem = "320";
                }
                // Low
                else if (vm.Preset_SelectedItem == "MP3 Low")
                {
                    vm.Audio_Quality_SelectedItem = "160";
                }

                vm.Audio_VBR_IsChecked = true;
                vm.Audio_CompressionLevel_SelectedItem = "auto";
                vm.Audio_SampleRate_SelectedItem = "auto";
                vm.Audio_BitDepth_SelectedItem = "auto";
                vm.Audio_Volume_Text = "100";
                vm.Audio_HardLimiter_Value = 1;

                // Filters
                vm.FiltersSetDefault();
            }

            // -------------------------
            // iTunes
            // -------------------------
            else if (vm.Preset_SelectedItem == "iTunes")
            {
                //vm.Preset.IsEditable = false;

                // Format
                vm.Format_Container_SelectedItem = "m4a";
                vm.Format_Cut_SelectedItem = "No";
                vm.Format_CutStart_Hours_Text = "00";
                vm.Format_CutStart_Minutes_Text = "00";
                vm.Format_CutStart_Seconds_Text = "00";
                vm.Format_CutStart_Milliseconds_Text = "000";
                vm.Format_CutEnd_Hours_Text = "00";
                vm.Format_CutEnd_Minutes_Text = "00";
                vm.Format_CutEnd_Seconds_Text = "00";
                vm.Format_CutEnd_Milliseconds_Text = "000";

                // Video
                vm.Video_Codec_SelectedItem = "None";
                vm.Video_EncodeSpeed_SelectedItem = "None";
                vm.Video_Quality_SelectedItem = "None";
                vm.Video_Pass_SelectedItem = "auto";
                vm.Video_Bitrate_Text = "";
                vm.Video_Minrate_Text = "";
                vm.Video_Maxrate_Text = "";
                vm.Video_Bufsize_Text = "";
                vm.Video_PixelFormat_SelectedItem = "none";
                vm.Video_FPS_SelectedItem = "auto";
                vm.Video_Optimize_SelectedItem = "None";
                vm.Video_Scale_SelectedItem = "Source";
                vm.Video_ScalingAlgorithm_SelectedItem = "auto";
                vm.Video_AspectRatio_SelectedItem = "auto";

                // Subtitle
                vm.Subtitle_Codec_SelectedItem = "None";
                vm.Subtitle_Stream_SelectedItem = "none";

                // Audio
                vm.Audio_Codec_SelectedItem = "AAC";
                vm.Audio_Stream_SelectedItem = "1";
                vm.Audio_Channel_SelectedItem = "Stereo";
                vm.Audio_Quality_SelectedItem = "320";
                vm.Audio_VBR_IsChecked = true;
                vm.Audio_CompressionLevel_SelectedItem = "auto";
                vm.Audio_SampleRate_SelectedItem = "auto";
                vm.Audio_BitDepth_SelectedItem = "auto";
                vm.Audio_Volume_Text = "100";
                vm.Audio_HardLimiter_Value = 1;

                // Filters
                vm.FiltersSetDefault();
            }

            // -------------------------
            // Voice
            // -------------------------
            else if (vm.Preset_SelectedItem == "Voice")
            {
                //vm.Preset.IsEditable = false;

                // Format
                vm.Format_Container_SelectedItem = "ogg";
                vm.Format_Cut_SelectedItem = "No";
                vm.Format_CutStart_Hours_Text = "00";
                vm.Format_CutStart_Minutes_Text = "00";
                vm.Format_CutStart_Seconds_Text = "00";
                vm.Format_CutStart_Milliseconds_Text = "000";
                vm.Format_CutEnd_Hours_Text = "00";
                vm.Format_CutEnd_Minutes_Text = "00";
                vm.Format_CutEnd_Seconds_Text = "00";
                vm.Format_CutEnd_Milliseconds_Text = "000";

                // Video
                vm.Video_Codec_SelectedItem = "None";
                vm.Video_EncodeSpeed_SelectedItem = "None";
                vm.Video_Quality_SelectedItem = "None";
                vm.Video_Pass_SelectedItem = "auto";
                vm.Video_Bitrate_Text = "";
                vm.Video_Minrate_Text = "";
                vm.Video_Maxrate_Text = "";
                vm.Video_Bufsize_Text = "";
                vm.Video_PixelFormat_SelectedItem = "none";
                vm.Video_FPS_SelectedItem = "auto";
                vm.Video_Optimize_SelectedItem = "None";
                vm.Video_Scale_SelectedItem = "Source";
                vm.Video_ScalingAlgorithm_SelectedItem = "auto";
                vm.Video_AspectRatio_SelectedItem = "auto";

                // Subtitle
                vm.Subtitle_Codec_SelectedItem = "None";
                vm.Subtitle_Stream_SelectedItem = "none";

                // Audio
                vm.Audio_Codec_SelectedItem = "Opus";
                vm.Audio_Stream_SelectedItem = "1";
                vm.Audio_Channel_SelectedItem = "Source";
                vm.Audio_Quality_SelectedItem = "96";
                vm.Audio_VBR_IsChecked = true;
                vm.Audio_CompressionLevel_SelectedItem = "10";
                vm.Audio_SampleRate_SelectedItem = "auto";
                vm.Audio_BitDepth_SelectedItem = "auto";
                vm.Audio_Volume_Text = "100";
                vm.Audio_HardLimiter_Value = 1;

                // Filters
                vm.FiltersSetDefault();
            }

            // ---------------------------------------------------------------------------
            // YouTube
            // ---------------------------------------------------------------------------
            // -------------------------
            // Video
            // -------------------------
            else if (vm.Preset_SelectedItem == "Video")
            {
                //vm.Preset.IsEditable = false;

                // Format
                vm.Format_Container_SelectedItem = "mp4";
                vm.Format_Cut_SelectedItem = "No";
                vm.Format_CutStart_Hours_Text = "00";
                vm.Format_CutStart_Minutes_Text = "00";
                vm.Format_CutStart_Seconds_Text = "00";
                vm.Format_CutStart_Milliseconds_Text = "000";
                vm.Format_CutEnd_Hours_Text = "00";
                vm.Format_CutEnd_Minutes_Text = "00";
                vm.Format_CutEnd_Seconds_Text = "00";
                vm.Format_CutEnd_Milliseconds_Text = "000";

                // Video
                vm.Video_Codec_SelectedItem = "Copy";
                vm.Video_EncodeSpeed_SelectedItem = "None";
                vm.Video_Quality_SelectedItem = "Auto";
                vm.Video_Pass_SelectedItem = "auto";
                vm.Video_Bitrate_Text = "";
                vm.Video_Minrate_Text = "";
                vm.Video_Maxrate_Text = "";
                vm.Video_Bufsize_Text = "";
                vm.Video_PixelFormat_SelectedItem = "auto";
                vm.Video_FPS_SelectedItem = "auto";
                vm.Video_Optimize_SelectedItem = "None";
                vm.Video_Optimize_Tune_SelectedItem = "none";
                vm.Video_Optimize_Profile_SelectedItem = "none";
                vm.Video_Optimize_Level_SelectedItem = "none";
                vm.Video_Scale_SelectedItem = "Source";
                vm.Video_ScalingAlgorithm_SelectedItem = "auto";
                vm.Video_AspectRatio_SelectedItem = "auto";

                // Subtitle
                vm.Subtitle_Codec_SelectedItem = "Copy";
                vm.Subtitle_Stream_SelectedItem = "none";

                // Audio
                vm.Audio_Codec_SelectedItem = "Copy";
                vm.Audio_Stream_SelectedItem = "all";
                vm.Audio_Channel_SelectedItem = "Source";
                vm.Audio_Quality_SelectedItem = "Auto";
                vm.Audio_VBR_IsChecked = false;
                vm.Audio_CompressionLevel_SelectedItem = "auto";
                vm.Audio_SampleRate_SelectedItem = "auto";
                vm.Audio_BitDepth_SelectedItem = "auto";
                vm.Audio_Volume_Text = "100";
                vm.Audio_HardLimiter_Value = 1;

                // Filters
                vm.FiltersSetDefault();
            }

            // -------------------------
            // Music
            // -------------------------
            else if (vm.Preset_SelectedItem == "Music")
            {
                //vm.Preset.IsEditable = false;

                // Format
                vm.Format_Container_SelectedItem = "m4a";
                vm.Format_Cut_SelectedItem = "No";
                vm.Format_CutStart_Hours_Text = "00";
                vm.Format_CutStart_Minutes_Text = "00";
                vm.Format_CutStart_Seconds_Text = "00";
                vm.Format_CutStart_Milliseconds_Text = "000";
                vm.Format_CutEnd_Hours_Text = "00";
                vm.Format_CutEnd_Minutes_Text = "00";
                vm.Format_CutEnd_Seconds_Text = "00";
                vm.Format_CutEnd_Milliseconds_Text = "000";

                // Video
                vm.Video_Codec_SelectedItem = "None";
                vm.Video_EncodeSpeed_SelectedItem = "None";
                vm.Video_Quality_SelectedItem = "None";
                vm.Video_Pass_SelectedItem = "auto";
                vm.Video_Bitrate_Text = "";
                vm.Video_Minrate_Text = "";
                vm.Video_Maxrate_Text = "";
                vm.Video_Bufsize_Text = "";
                vm.Video_PixelFormat_SelectedItem = "none";
                vm.Video_FPS_SelectedItem = "auto";
                vm.Video_Optimize_SelectedItem = "None";
                vm.Video_Scale_SelectedItem = "Source";
                vm.Video_ScalingAlgorithm_SelectedItem = "auto";
                vm.Video_AspectRatio_SelectedItem = "auto";

                // Subtitle
                vm.Subtitle_Codec_SelectedItem = "None";
                vm.Subtitle_Stream_SelectedItem = "none";

                // Audio
                vm.Audio_Codec_SelectedItem = "Copy";
                vm.Audio_Stream_SelectedItem = "1";
                vm.Audio_Channel_SelectedItem = "Source";
                vm.Audio_Quality_SelectedItem = "Auto";
                vm.Audio_VBR_IsChecked = true;
                vm.Audio_CompressionLevel_SelectedItem = "auto";
                vm.Audio_SampleRate_SelectedItem = "auto";
                vm.Audio_BitDepth_SelectedItem = "auto";
                vm.Audio_Volume_Text = "100";
                vm.Audio_HardLimiter_Value = 1;

                // Filters
                vm.FiltersSetDefault();
            }

            // ---------------------------------------------------------------------------
            // Debug
            // ---------------------------------------------------------------------------
            else if (vm.Preset_SelectedItem == "Debug")
            {
                //vm.Preset.IsEditable = false;

                // Format
                vm.Format_Container_SelectedItem = "mkv";
                vm.Format_Cut_SelectedItem = "Yes";
                vm.Format_CutStart_Hours_Text = "00";
                vm.Format_CutStart_Minutes_Text = "00";
                vm.Format_CutStart_Seconds_Text = "03";
                vm.Format_CutStart_Milliseconds_Text = "250";
                vm.Format_CutEnd_Hours_Text = "00";
                vm.Format_CutEnd_Minutes_Text = "00";
                vm.Format_CutEnd_Seconds_Text = "12";
                vm.Format_CutEnd_Milliseconds_Text = "400";

                // Video
                vm.Video_Codec_SelectedItem = "x264";
                vm.Video_EncodeSpeed_SelectedItem = "Faster";
                vm.Video_Quality_SelectedItem = "Custom";
                vm.Video_Pass_SelectedItem = "CRF";
                vm.Video_Bitrate_Text = "1250K";
                vm.Video_Minrate_Text = "";
                vm.Video_Maxrate_Text = "";
                vm.Video_Bufsize_Text = "";
                vm.Video_CRF_Text = "26";
                vm.Video_PixelFormat_SelectedItem = "yuv444p";
                vm.Video_FPS_SelectedItem = "29.97";
                vm.Video_Optimize_SelectedItem = "Windows";
                vm.Video_Scale_SelectedItem = "Custom";
                vm.Video_Width_Text = "545";
                vm.Video_Height_Text = "307";
                vm.Video_ScalingAlgorithm_SelectedItem = "spline";
                vm.Video_AspectRatio_SelectedItem = "16:9";

                // Subtitle
                vm.Subtitle_Codec_SelectedItem = "SSA";
                vm.Subtitle_Stream_SelectedItem = "all";

                // Audio
                vm.Audio_Codec_SelectedItem = "Opus";
                vm.Audio_Stream_SelectedItem = "1";
                vm.Audio_Channel_SelectedItem = "Stereo";
                vm.Audio_Quality_SelectedItem = "Custom";
                vm.Audio_Bitrate_Text = "380";
                vm.Audio_VBR_IsChecked = true;
                vm.Audio_CompressionLevel_SelectedItem = "8";
                vm.Audio_SampleRate_SelectedItem = "48k";
                vm.Audio_BitDepth_SelectedItem = "auto";
                vm.Audio_Volume_Text = "120";
                vm.Audio_HardLimiter_Value = 0.9;

                // Filters
                vm.FiltersSetDefault();
            }
        }
    }
}
