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
type ImageSegmentAnimation =
    inherit ImageAnimation
    [<DefaultValue(false)>] val mutable startX : int
    [<DefaultValue(false)>] val mutable startY : int
    [<DefaultValue(false)>] val mutable drawWidth : int
    [<DefaultValue(false)>] val mutable drawHeight : int
    [<DefaultValue(false)>] val mutable circularIndexUtil : CircularIndexUtil
    [<DefaultValue(false)>] val mutable sequenceArray : int[]
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not ImageSegmentAnimation.jclinitDone then
            ImageSegmentAnimation.jclinitDone <- true
            ImageSegmentAnimation.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (image: Image, sequenceArray: int[], animationBehavior: AnimationBehavior) as this =
        { inherit ImageAnimation(image, animationBehavior) }
        then
            this.jctor1(image, sequenceArray, animationBehavior)
    member this.jctor1(image: Image, sequenceArray: int[], animationBehavior: AnimationBehavior) : unit =
        ()
        this.startX <- 0
        this.startY <- 0
        this.drawWidth <- this.getImage().getWidth()
        this.drawHeight <- this.getImage().getHeight()
        this.circularIndexUtil <- CircularIndexUtil.createInstance(this.drawHeight)
        this.sequenceArray <- sequenceArray
        ()
    
    override this.nextFrame() : unit =
        ignore (this.circularIndexUtil.next())
    
    override this.previousFrame() : unit =
        ignore (this.circularIndexUtil.previous())
    
    override this.setFrame(index: int) : unit =
        this.circularIndexUtil.setIndex(index)
    
    override this.getFrame() : int =
        this.circularIndexUtil.getIndex()
    
    override this.getSize() : int =
        this.circularIndexUtil.getSize()
    
    override this.setSequence(sequenceArray: int[]) : unit =
        this.sequenceArray <- sequenceArray
    
    override this.getSequence() : int[] =
        this.sequenceArray
    
    override this.paintXY(graphics: Graphics, x: int, y: int) : unit =
        ()
    
    abstract getStartX : unit -> int
    default this.getStartX() : int =
        this.startX
    
    abstract setStartX : startX: int -> unit
    default this.setStartX(startX: int) : unit =
        this.startX <- startX
    
    abstract getStartY : unit -> int
    default this.getStartY() : int =
        this.startY
    
    abstract setStartY : startY: int -> unit
    default this.setStartY(startY: int) : unit =
        this.startY <- startY
    
    abstract getDrawWidth : unit -> int
    default this.getDrawWidth() : int =
        this.drawWidth
    
    abstract setDrawWidth : drawWidth: int -> unit
    default this.setDrawWidth(drawWidth: int) : unit =
        this.drawWidth <- drawWidth
    
    abstract getDrawHeight : unit -> int
    default this.getDrawHeight() : int =
        this.drawHeight
    
    abstract setDrawHeight : drawHeight: int -> unit
    default this.setDrawHeight(drawHeight: int) : unit =
        this.drawHeight <- drawHeight


