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
type ImageArrayRotationAnimationInfo =
    [<DefaultValue(false)>] val mutable imageArray : Image[]
    [<DefaultValue(false)>] val mutable angleIncrement : int
    [<DefaultValue(false)>] val mutable totalAngle : int
    [<DefaultValue(false)>] val mutable dx : int
    [<DefaultValue(false)>] val mutable dy : int
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not ImageArrayRotationAnimationInfo.jclinitDone then
            ImageArrayRotationAnimationInfo.jclinitDone <- true
            ImageArrayRotationAnimationInfo.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (imageArray: Image[], angleIncrement: int, totalAngle: int, dx: int, dy: int) as this =
        {  }
        then
            this.jctor1(imageArray, angleIncrement, totalAngle, dx, dy)
    member this.jctor1(imageArray: Image[], angleIncrement: int, totalAngle: int, dx: int, dy: int) : unit =
        this.imageArray <- imageArray
        this.angleIncrement <- angleIncrement
        this.totalAngle <- totalAngle
        this.dx <- dx
        this.dy <- dy
        ()
    
    abstract setImageArray : imageArray: Image[] -> unit
    default this.setImageArray(imageArray: Image[]) : unit =
        this.imageArray <- imageArray
    
    abstract getImageArray : unit -> Image[]
    default this.getImageArray() : Image[] =
        this.imageArray
    
    abstract getAngleInfoP : unit -> AngleInfo
    default this.getAngleInfoP() : AngleInfo =
        AngleInfo.getInstance(int16 (this.angleIncrement))
    
    abstract setTotalAngle : totalAngle: int -> unit
    default this.setTotalAngle(totalAngle: int) : unit =
        this.totalAngle <- totalAngle
    
    abstract getTotalAngle : unit -> int
    default this.getTotalAngle() : int =
        this.totalAngle
    
    abstract setDx : dx: int -> unit
    default this.setDx(dx: int) : unit =
        this.dx <- dx
    
    abstract getDx : unit -> int
    default this.getDx() : int =
        this.dx
    
    abstract setDy : dy: int -> unit
    default this.setDy(dy: int) : unit =
        this.dy <- dy
    
    abstract getDy : unit -> int
    default this.getDy() : int =
        this.dy


