using System;
using MonoTouch.ObjCRuntime;

[assembly: LinkWith ("libpop.a", LinkTarget.Simulator | LinkTarget.ArmV7 | LinkTarget.ArmV7s, ForceLoad = true, IsCxx=true)]