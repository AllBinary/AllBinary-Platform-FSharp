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
type SpecialAnimation =
    inherit IndexedAnimation
    [<DefaultValue(false)>] static val mutable private jcell_NULL_SPECIAL_ANIMATION : SpecialAnimation
    static member NULL_SPECIAL_ANIMATION with get() : SpecialAnimation = (SpecialAnimation.jclinit(); SpecialAnimation.jcell_NULL_SPECIAL_ANIMATION) and set (jvalue: SpecialAnimation) = (SpecialAnimation.jclinit(); SpecialAnimation.jcell_NULL_SPECIAL_ANIMATION <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not SpecialAnimation.jclinitDone then
            SpecialAnimation.jclinitDone <- true
            SpecialAnimation.jclinitBody()
    static member private jclinitBody() : unit =
        SpecialAnimation.jcell_NULL_SPECIAL_ANIMATION <- (new SpecialAnimation((new IndexedAnimationBehavior(1, 250L))))
        ()
    
    static member getInstance() : SpecialAnimation =
        SpecialAnimation.NULL_SPECIAL_ANIMATION
    
    new (animationBehavior: AnimationBehavior) =
        { inherit IndexedAnimation(animationBehavior) }
    
    override this.nextFrame() : unit =
        let mutable indexedAnimationBehavior : IndexedAnimationBehavior = ((box (this.animationBehaviorP) :?> IndexedAnimationBehavior))
        indexedAnimationBehavior.loopIndex <- indexedAnimationBehavior.loopIndex + 1
    
    abstract setLastFrame : unit -> unit
    default this.setLastFrame() : unit =
        ()
    
    abstract isComplete : unit -> bool
    default this.isComplete() : bool =
        false
    
    abstract open_ : unit -> unit
    default this.open_() : unit =
        ()
    
    abstract close : unit -> unit
    default this.close() : unit =
        ()
    
    abstract process_ : unit -> unit
    default this.process_() : unit =
        ()
    interface SpecialAnimationInterface with
        member this.setLastFrame() : unit = this.setLastFrame()
        member this.isComplete() : bool = this.isComplete()
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


