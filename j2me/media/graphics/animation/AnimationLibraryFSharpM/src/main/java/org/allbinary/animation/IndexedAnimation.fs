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
type IndexedAnimation =
    inherit Animation
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] val mutable commonStrings : CommonStrings
    [<DefaultValue(false)>] val mutable animationBehaviorP : AnimationBehavior
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not IndexedAnimation.jclinitDone then
            IndexedAnimation.jclinitDone <- true
            IndexedAnimation.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_IndexedAnimation() : unit =
        this.logUtil <- LogUtil.getInstance()
        this.commonStrings <- CommonStrings.getInstance()
        ()
    
    new (animationBehavior: AnimationBehavior) as this =
        { inherit Animation() }
        then
            this.jfields_IndexedAnimation()
            this.jctor1(animationBehavior)
    member this.jctor1(animationBehavior: AnimationBehavior) : unit =
        this.animationBehaviorP <- animationBehavior
        ()
    
    abstract getAnimationBehavior : unit -> AnimationBehavior
    default this.getAnimationBehavior() : AnimationBehavior =
        this.animationBehaviorP
    
    abstract reset : unit -> unit
    default this.reset() : unit =
        this.animationBehaviorP.reset()
        this.setFrame(0)
    
    abstract setFrame : index: int -> unit
    default this.setFrame(index: int) : unit =
        ()
    
    abstract getFrame : unit -> int
    default this.getFrame() : int =
        0
    
    abstract getAnimationSize : unit -> int
    default this.getAnimationSize() : int =
        raise ((new JException(this.commonStrings.NOT_IMPLEMENTED)))
    
    abstract getSize : unit -> int
    default this.getSize() : int =
        0
    
    abstract previousFrame : unit -> unit
    default this.previousFrame() : unit =
        ()
    
    abstract isLastFrame : unit -> bool
    default this.isLastFrame() : bool =
        let mutable jflow = 0
        let mutable jret : bool = Unchecked.defaultof<bool>
        if this.getFrame() = (this.getSize() - 1) then
            jret <- true
            jflow <- 1
        else
            jret <- false
            jflow <- 1
        jret
    
    abstract setSequence : sequence: int[] -> unit
    default this.setSequence(sequence: int[]) : unit =
        ()
    
    abstract getSequence : unit -> int[]
    default this.getSequence() : int[] =
        PrimitiveIntUtil.getArrayInstance()
    
    abstract setState : indexedAnimation: IndexedAnimation -> unit
    default this.setState(indexedAnimation: IndexedAnimation) : unit =
        this.setFrame(indexedAnimation.getFrame())
        this.setDx(indexedAnimation.getDx())
        this.setDy(indexedAnimation.getDy())
    
    abstract getWidth : unit -> int
    default this.getWidth() : int =
        0
    
    abstract getHeight : unit -> int
    default this.getHeight() : int =
        0
    interface IndexedAnimationInterface with
        member this.reset() : unit = this.reset()
        member this.setFrame(jp0: int) : unit = this.setFrame(jp0)
        member this.getFrame() : int = this.getFrame()
    interface SequentialAnimationInterface with
        member this.getSize() : int = this.getSize()
        member this.previousFrame() : unit = this.previousFrame()
    interface AnimationInterface with
        member this.nextFrame() : unit = this.nextFrame()
        member this.paintThreedXYZ(jp0: Graphics, jp1: int, jp2: int, jp3: int) : unit = this.paintThreedXYZ(jp0, jp1, jp2, jp3)
    interface SequenceInterface with
        member this.setSequence(jp0: int[]) : unit = this.setSequence(jp0)
        member this.getSequence() : int[] = this.getSequence()
    interface LocationPaintableInterface with
        member this.paintXY(jp0: Graphics, jp1: int, jp2: int) : unit = this.paintXY(jp0, jp1, jp2)


