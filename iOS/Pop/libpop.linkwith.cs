using System;
using ObjCRuntime;

[assembly: LinkWith ("libpop.a", LinkTarget.ArmV7 | LinkTarget.ArmV7s | LinkTarget.Arm64 | LinkTarget.Simulator, SmartLink = true, IsCxx = true, Frameworks="CoreImage", LinkerFlags = "-ObjC")]
