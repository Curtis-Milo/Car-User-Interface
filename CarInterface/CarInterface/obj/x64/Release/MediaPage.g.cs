﻿#pragma checksum "D:\curtm\Desktop\Car-User-Interface\CarInterface\CarInterface\MediaPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "B7EBB7F900927FD47DD039EEC1A4F253"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CarInterface
{
    partial class MediaPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.recRightSide = (global::Windows.UI.Xaml.Shapes.Rectangle)(target);
                }
                break;
            case 2:
                {
                    this.recLeftSide = (global::Windows.UI.Xaml.Shapes.Rectangle)(target);
                }
                break;
            case 3:
                {
                    this.recBotSide = (global::Windows.UI.Xaml.Shapes.Rectangle)(target);
                }
                break;
            case 4:
                {
                    this.btCall = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 18 "..\..\..\MediaPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btCall).Click += this.btCall_Click;
                    #line default
                }
                break;
            case 5:
                {
                    this.btAir = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 19 "..\..\..\MediaPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btAir).Click += this.btAir_Click;
                    #line default
                }
                break;
            case 6:
                {
                    this.btMedia = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 20 "..\..\..\MediaPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btMedia).Click += this.btMedia_Click;
                    #line default
                }
                break;
            case 7:
                {
                    this.btNav = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 21 "..\..\..\MediaPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btNav).Click += this.btNav_Click;
                    #line default
                }
                break;
            case 8:
                {
                    this.btSetting = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 22 "..\..\..\MediaPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btSetting).Click += this.btSettings_Click;
                    #line default
                }
                break;
            case 9:
                {
                    this.btPlaylist1 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 23 "..\..\..\MediaPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btPlaylist1).Click += this.btPlaylist1_Click;
                    #line default
                }
                break;
            case 10:
                {
                    this.btPlaylist2 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 24 "..\..\..\MediaPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btPlaylist2).Click += this.btPlaylist2_Click;
                    #line default
                }
                break;
            case 11:
                {
                    this.btPlaylist3 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 25 "..\..\..\MediaPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btPlaylist3).Click += this.btPlaylist3_Click;
                    #line default
                }
                break;
            case 12:
                {
                    this.btPlaylist4 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 26 "..\..\..\MediaPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btPlaylist4).Click += this.btPlaylist4_Click;
                    #line default
                }
                break;
            case 13:
                {
                    this.btPlaylist5 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 27 "..\..\..\MediaPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btPlaylist5).Click += this.btPlaylist5_Click;
                    #line default
                }
                break;
            case 14:
                {
                    this.lblSong = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 15:
                {
                    this.lblArtist = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 16:
                {
                    this.lblPlaylist = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 17:
                {
                    this.btSet = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 31 "..\..\..\MediaPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btSet).Click += this.btsetPlaylist_Click;
                    #line default
                }
                break;
            case 18:
                {
                    this.btForward = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 32 "..\..\..\MediaPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btForward).Click += this.btTuneForward_Click;
                    #line default
                }
                break;
            case 19:
                {
                    this.btBack = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 40 "..\..\..\MediaPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btBack).Click += this.btTuneBack_Click;
                    #line default
                }
                break;
            case 20:
                {
                    this.btAC = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 48 "..\..\..\MediaPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btAC).Click += this.btAC_Click;
                    #line default
                }
                break;
            case 21:
                {
                    this.ledAC = (global::Windows.UI.Xaml.Shapes.Ellipse)(target);
                }
                break;
            case 22:
                {
                    this.btIntCirc = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 50 "..\..\..\MediaPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btIntCirc).Click += this.btIntCirc_Click;
                    #line default
                }
                break;
            case 23:
                {
                    this.btFrontDefrost = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 55 "..\..\..\MediaPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btFrontDefrost).Click += this.btFrontDefrost_Click;
                    #line default
                }
                break;
            case 24:
                {
                    this.btRearDefrost = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 60 "..\..\..\MediaPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btRearDefrost).Click += this.btRearDefrost_Click;
                    #line default
                }
                break;
            case 25:
                {
                    this.ledRearDefrost = (global::Windows.UI.Xaml.Shapes.Ellipse)(target);
                }
                break;
            case 26:
                {
                    this.ledFrontDefrost = (global::Windows.UI.Xaml.Shapes.Ellipse)(target);
                }
                break;
            case 27:
                {
                    this.btTempRU = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 67 "..\..\..\MediaPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btTempRU).Click += this.btTempRU_Click;
                    #line default
                }
                break;
            case 28:
                {
                    this.btMute = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 72 "..\..\..\MediaPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btMute).Click += this.btMute_Click;
                    #line default
                }
                break;
            case 29:
                {
                    this.btHazard = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 73 "..\..\..\MediaPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btHazard).Click += this.btHazard_Click;
                    #line default
                }
                break;
            case 30:
                {
                    this.btTempRD = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 81 "..\..\..\MediaPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btTempRD).Click += this.btTempRD_Click;
                    #line default
                }
                break;
            case 31:
                {
                    this.btTempLU = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 86 "..\..\..\MediaPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btTempLU).Click += this.btTempLU_Click;
                    #line default
                }
                break;
            case 32:
                {
                    this.btTempLD = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 91 "..\..\..\MediaPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btTempLD).Click += this.btTempLD_Click;
                    #line default
                }
                break;
            case 33:
                {
                    this.ledIntCirc = (global::Windows.UI.Xaml.Shapes.Ellipse)(target);
                }
                break;
            case 34:
                {
                    this.ledHazard = (global::Windows.UI.Xaml.Shapes.Ellipse)(target);
                }
                break;
            case 35:
                {
                    global::Windows.UI.Xaml.Controls.Grid element35 = (global::Windows.UI.Xaml.Controls.Grid)(target);
                    #line 98 "..\..\..\MediaPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Grid)element35).ManipulationDelta += this.Grid_ManipulationVolume;
                    #line default
                }
                break;
            case 36:
                {
                    global::Windows.UI.Xaml.Controls.Grid element36 = (global::Windows.UI.Xaml.Controls.Grid)(target);
                    #line 101 "..\..\..\MediaPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Grid)element36).ManipulationDelta += this.Grid_ManipulationTune;
                    #line default
                }
                break;
            case 37:
                {
                    global::Windows.UI.Xaml.Controls.Grid element37 = (global::Windows.UI.Xaml.Controls.Grid)(target);
                    #line 104 "..\..\..\MediaPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Grid)element37).ManipulationDelta += this.Grid_ManipulationAir;
                    #line default
                }
                break;
            case 38:
                {
                    this.lblVolume = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 39:
                {
                    this.lblTune = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 40:
                {
                    this.lblAir = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 41:
                {
                    this.btVoice = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 110 "..\..\..\MediaPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btVoice).Click += this.btSetSong_Click;
                    #line default
                }
                break;
            case 42:
                {
                    this.lblTime = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 43:
                {
                    this.dlAir = (global::CarInterface.Dial)(target);
                }
                break;
            case 44:
                {
                    this.dlTune = (global::CarInterface.Dial)(target);
                }
                break;
            case 45:
                {
                    this.dlVolume = (global::CarInterface.Dial)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

