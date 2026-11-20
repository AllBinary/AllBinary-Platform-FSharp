namespace rec AllBinary

// Generated Code Do Not Modify
(*
 *
 * AllBinary Open License Version 1
 * Copyright (c) 2011 AllBinary
 * 
 * By agreeing to this license you and any business entity you represent are
 * legally bound to the AllBinary Open License Version 1 legal agreement.
 * 
 * You may obtain the AllBinary Open License Version 1 legal agreement from
 * AllBinary or the root directory of AllBinary's AllBinary Platform repository.
 * 
 * Created By: Travis Berthelot
 *  
 *)

[<AllowNullLiteral>]
type Animation =
    [<DefaultValue(false)>] val mutable basicSetColorUtil : BasicColorSetUtil
    [<DefaultValue(false)>] val mutable basicColor : BasicColor
    [<DefaultValue(false)>] val mutable colorP : int
    [<DefaultValue(false)>] val mutable changeBasicColorP : BasicColor
    [<DefaultValue(false)>] val mutable changeColorP : int
    [<DefaultValue(false)>] val mutable alphaP : int
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not Animation.jclinitDone then
            Animation.jclinitDone <- true
            Animation.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_Animation() : unit =
        this.basicSetColorUtil <- BasicColorSetUtil.getInstance()
        this.basicColor <- BasicColorFactory.getInstance().WHITE
        this.changeBasicColorP <- BasicColorFactory.getInstance().NULL_COLOR
        ()
    
    new () as this =
        {  }
        then
            this.jfields_Animation()
    
    abstract setAlpha : alpha: int -> unit
    default this.setAlpha(alpha: int) : unit =
        this.alphaP <- alpha
    
    abstract nextFrame : unit -> unit
    default this.nextFrame() : unit =
        ()
    
    abstract paintXY : graphics: Graphics * x: int * y: int -> unit
    default this.paintXY(graphics: Graphics, x: int, y: int) : unit =
        this.basicSetColorUtil.setBasicColorP3(graphics, this.getBasicColorP(), this.getColor())
    
    abstract paintThreedXYZ : graphics: Graphics * x: int * y: int * z: int -> unit
    default this.paintThreedXYZ(graphics: Graphics, x: int, y: int, z: int) : unit =
        ()
    
    abstract isThreed : unit -> bool
    default this.isThreed() : bool =
        false
    
    abstract getBasicColorP : unit -> BasicColor
    default this.getBasicColorP() : BasicColor =
        this.basicColor
    
    abstract setBasicColorP : basicColor: BasicColor -> unit
    default this.setBasicColorP(basicColor: BasicColor) : unit =
        this.basicColor <- basicColor
        this.colorP <- this.basicColor.intValue()
    
    abstract setBackgroundBasicColorP : basicColor: BasicColor -> unit
    default this.setBackgroundBasicColorP(basicColor: BasicColor) : unit =
        ()
    
    abstract getChangeBasicColor : unit -> BasicColor
    default this.getChangeBasicColor() : BasicColor =
        this.changeBasicColorP
    
    abstract changeBasicColor : basicColor: BasicColor -> unit
    default this.changeBasicColor(basicColor: BasicColor) : unit =
        this.changeBasicColorP <- basicColor
        this.changeColorP <- this.changeBasicColorP.intValue()
    
    abstract getChangeColor : unit -> int
    default this.getChangeColor() : int =
        this.changeColorP
    
    abstract getColor : unit -> int
    default this.getColor() : int =
        this.colorP
    
    abstract setScale : scaleX: float32 * scaleY: float32 -> unit
    default this.setScale(scaleX: float32, scaleY: float32) : unit =
        ()
    
    abstract setMaxScale : maxScaleX: float32 * maxScaleY: float32 -> unit
    default this.setMaxScale(maxScaleX: float32, maxScaleY: float32) : unit =
        ()
    
    abstract set : gl: GL -> unit
    default this.set(gl: GL) : unit =
        ()
    
    abstract setDx : dx: int -> unit
    default this.setDx(dx: int) : unit =
        ()
    
    abstract getDx : unit -> int
    default this.getDx() : int =
        0
    
    abstract setDy : dy: int -> unit
    default this.setDy(dy: int) : unit =
        ()
    
    abstract getDy : unit -> int
    default this.getDy() : int =
        0
    interface AnimationInterface with
        member this.nextFrame() : unit = this.nextFrame()
        member this.paintThreedXYZ(jp0: Graphics, jp1: int, jp2: int, jp3: int) : unit = this.paintThreedXYZ(jp0, jp1, jp2, jp3)
    interface OpenGLSurfaceChangedInterface with
        member this.set(jp0: GL) : unit = this.set(jp0)
    interface LocationPaintableInterface with
        member this.paintXY(jp0: Graphics, jp1: int, jp2: int) : unit = this.paintXY(jp0, jp1, jp2)


