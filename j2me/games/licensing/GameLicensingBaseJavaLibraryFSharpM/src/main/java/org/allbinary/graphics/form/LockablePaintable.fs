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
type LockablePaintable =
    inherit ItemPaintable
    [<DefaultValue(false)>] val mutable animation : Animation
    [<DefaultValue(false)>] val mutable lockedIndex : int
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not LockablePaintable.jclinitDone then
            LockablePaintable.jclinitDone <- true
            LockablePaintable.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_LockablePaintable() : unit =
        this.animation <- FeaturedAnimationInterfaceFactoryInterfaceFactory.getInstance().get(LockedResources.getInstance().LOCKED_DEMO_GAME_FEATURE_RESOURCE).getInstance(0)
        ()
    
    new (lockedIndex: int) as this =
        { inherit ItemPaintable() }
        then
            this.jfields_LockablePaintable()
            this.jctor1(lockedIndex)
    member this.jctor1(lockedIndex: int) : unit =
        this.lockedIndex <- lockedIndex
        ()
    
    override this.paint(graphics: Graphics, currentIndex: int, x: int, y: int) : unit =
        if LockedUtil.getInstance().isLocked() && (currentIndex >= this.getLockedIndex()) then
            this.getAnimation().paintXY(graphics, x, y)
    
    abstract getLockedIndex : unit -> int
    default this.getLockedIndex() : int =
        this.lockedIndex
    
    abstract getAnimation : unit -> Animation
    default this.getAnimation() : Animation =
        this.animation


