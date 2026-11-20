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
type CaptionAnimationHelper =
    inherit CaptionAnimationHelperBase
    [<DefaultValue(false)>] val mutable timeHelper : TimeDelayHelper
    [<DefaultValue(false)>] val mutable textAnimation : TextAnimation
    [<DefaultValue(false)>] val mutable captionAnimation : Animation
    [<DefaultValue(false)>] val mutable animation : Animation
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not CaptionAnimationHelper.jclinitDone then
            CaptionAnimationHelper.jclinitDone <- true
            CaptionAnimationHelper.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_CaptionAnimationHelper() : unit =
        this.timeHelper <- (new TimeDelayHelper(620))
        this.textAnimation <- (new TextAnimation(StringUtil.getInstance().EMPTY_STRING, AnimationBehavior.getInstance()))
        this.animation <- NullAnimationFactory.getFactoryInstance().getInstance(0)
        ()
    
    new (captionAnimation: Animation, captionDx: int, captionDy: int, dx: int, dy: int) as this =
        { inherit CaptionAnimationHelperBase() }
        then
            this.jfields_CaptionAnimationHelper()
            this.jctor1(captionAnimation, captionDx, captionDy, dx, dy)
    member this.jctor1(captionAnimation: Animation, captionDx: int, captionDy: int, dx: int, dy: int) : unit =
        this.captionAnimation <- (new CaptionAnimation(captionAnimation, this.textAnimation, captionDx, captionDy, dx, dy))
        ()
    
    override this.isShowing() : bool =
        let mutable jflow = 0
        let mutable jret : bool = Unchecked.defaultof<bool>
        if (JR.same(this.animation, this.captionAnimation)) then
            jret <- true
            jflow <- 1
        else
            jret <- false
            jflow <- 1
        jret
    
    override this.tick() : unit =
        if this.timeHelper.isTime(GameTickTimeDelayHelperFactory.getInstance().startTime) then
            this.animation <- NullAnimationFactory.getFactoryInstance().getInstance(0)
    
    override this.update(message: string, basicColor: BasicColor) : unit =
        this.textAnimation.setBasicColorP(basicColor)
        this.textAnimation.setText(message)
        this.animation <- this.captionAnimation
        this.timeHelper.setStartTimeTNT()
    
    override this.paintXY(graphics: Graphics, x: int, y: int) : unit =
        this.animation.paintXY(graphics, x, y)


