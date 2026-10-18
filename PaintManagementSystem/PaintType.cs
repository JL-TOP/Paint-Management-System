using System;

namespace PaintManagementSystem;

// the enum needs public modifier. Because: 
// default modifier is internal. In PaintProduct,  public PaintType Type { get; set; } is problic propoerty.
public enum PaintType   
{
    BaseCoat,
    Glossy,
    Matte,
    SemiGloss,
    Gloss,
    WhiteOnWhite
}