﻿using System;
using System.Collections.Generic;
using System.Drawing;

namespace MechanismKinematicsWinFormsMVP
{
    public interface IMainFormView
    {
        Point Center { get; set; }
        int RadiusOne { get; set; }
        int RadiusTwo { get; set; }
        double Omega { get; set; }
        double Time { get; set; }
        Graphics Graphics { get; set; }
        bool Drawn { get; set; }
        Point PictureBoxLocation { get; set; }
        int PictureBoxWidth { get; set; }
        int PictureBoxHeight { get; set; }
        string LabelRadiusOneText { get; set; }
        string LabelRadiusTwoText { get; set; }
        string LabelOmegaText { get; set; }
        int TimerInterval { get; set; }
        bool ClearToolStripEnabled { get; set; }
        bool StartToolStripEnabled { get; set; }
        bool StopToolStripEnabled { get; set; }
        bool DrawToolStripEnabled { get; set; }
        bool KinematicToolStripEnabled { get; set; }
        bool GeometricToolStripEnabled { get; set; }
        int ClientSizeHeight { get; set; }
        int ClientSizeWidth { get; set; }
        int PanelHeight { get; set; }
        int MenuStripHeight { get; set; }
        bool TimerEnabled { get; set; }
        bool PointAChecked { get; set; }
        bool PointBChecked { get; set; }
        bool PointAEnabled { get; set; }
        bool PointBEnabled { get; set; }
        event EventHandler<EventArgs> AppOpen;
        event EventHandler<EventArgs> DrawMechanism;
        event EventHandler<EventArgs> StartMechanismAnimation;
        event EventHandler<EventArgs> StopMechanismAnimation;
        event EventHandler<EventArgs> ClearMechanism;
        event EventHandler<EventArgs> PictureBoxPaint;
        event EventHandler<EventArgs> GraphicsSetup;
        event EventHandler<EventArgs> TimerTick;
        event EventHandler<EventArgs> PointAMenuStripClick;
        event EventHandler<EventArgs> PointBMenuStripClick;
        event EventHandler<EventArgs> GeometricFormOpen;
        event EventHandler<EventArgs> KinematicFormOpen;
    }
}
