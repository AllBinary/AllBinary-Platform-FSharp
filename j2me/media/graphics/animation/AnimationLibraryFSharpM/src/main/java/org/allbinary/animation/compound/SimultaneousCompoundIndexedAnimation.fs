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
type SimultaneousCompoundIndexedAnimation =
    inherit IndexedAnimation
    [<DefaultValue(false)>] val mutable animationInterfaceArray : Animation[]
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not SimultaneousCompoundIndexedAnimation.jclinitDone then
            SimultaneousCompoundIndexedAnimation.jclinitDone <- true
            SimultaneousCompoundIndexedAnimation.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (animationInterfaceArray: Animation[], animationBehavior: AnimationBehavior) as this =
        { inherit IndexedAnimation(animationBehavior) }
        then
            this.jctor1(animationInterfaceArray, animationBehavior)
    member this.jctor1(animationInterfaceArray: Animation[], animationBehavior: AnimationBehavior) : unit =
        ()
        this.animationInterfaceArray <- animationInterfaceArray
        ()
    
    override this.setFrame(frameIndex: int) : unit =
        let mutable indexedAnimation : IndexedAnimation = null
        let mutable index : int = this.animationInterfaceArray.Length
        while ((index <- index - 1; index)) >= 0 do
            indexedAnimation <- (box (this.animationInterfaceArray.[index]) :?> IndexedAnimation)
            indexedAnimation.setFrame(frameIndex)
    
    override this.getFrame() : int =
        let mutable indexedAnimation : IndexedAnimation = (box (this.animationInterfaceArray.[0]) :?> IndexedAnimation)
        indexedAnimation.getFrame()
    
    override this.getSize() : int =
        let mutable indexedAnimation : IndexedAnimation = (box (this.animationInterfaceArray.[0]) :?> IndexedAnimation)
        indexedAnimation.getSize()
    
    override this.previousFrame() : unit =
        let mutable indexedAnimation : IndexedAnimation = null
        let mutable index : int = this.animationInterfaceArray.Length
        while ((index <- index - 1; index)) >= 0 do
            indexedAnimation <- (box (this.animationInterfaceArray.[index]) :?> IndexedAnimation)
            indexedAnimation.previousFrame()
    
    override this.setSequence(sequence: int[]) : unit =
        ()
    
    override this.getSequence() : int[] =
        PrimitiveIntUtil.getArrayInstance()
    
    override this.nextFrame() : unit =
        let mutable index : int = this.animationInterfaceArray.Length
        while ((index <- index - 1; index)) >= 0 do
            this.animationInterfaceArray.[index].nextFrame()
    
    override this.paintXY(graphics: Graphics, x: int, y: int) : unit =
        let mutable size : int = this.animationInterfaceArray.Length
        let mutable index : int = 0
        while index < size do
            this.animationInterfaceArray.[index].paintXY(graphics, x, y)
            index <- index + 1
    
    override this.paintThreedXYZ(graphics: Graphics, x: int, y: int, z: int) : unit =
        let mutable size : int = this.animationInterfaceArray.Length
        let mutable index : int = 0
        while index < size do
            this.animationInterfaceArray.[index].paintThreedXYZ(graphics, x, y, z)
            index <- index + 1
    
    abstract getAnimationInterfaceArray : unit -> Animation[]
    default this.getAnimationInterfaceArray() : Animation[] =
        this.animationInterfaceArray
    
    abstract setAnimationInterfaceArray : animationInterfaceArray: Animation[] -> unit
    default this.setAnimationInterfaceArray(animationInterfaceArray: Animation[]) : unit =
        this.animationInterfaceArray <- animationInterfaceArray


