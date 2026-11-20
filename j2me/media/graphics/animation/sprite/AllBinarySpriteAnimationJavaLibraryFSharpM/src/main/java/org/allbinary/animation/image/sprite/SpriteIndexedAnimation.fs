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
type SpriteIndexedAnimation =
    inherit IndexedAnimation
    [<DefaultValue(false)>] val mutable sprite : Sprite
    [<DefaultValue(false)>] val mutable image : Image
    [<DefaultValue(false)>] val mutable basicColorArray : BasicColor[]
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not SpriteIndexedAnimation.jclinitDone then
            SpriteIndexedAnimation.jclinitDone <- true
            SpriteIndexedAnimation.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (sprite: Sprite, image: Image, basicColorArray: BasicColor[], animationBehavior: AnimationBehavior) as this =
        { inherit IndexedAnimation(animationBehavior) }
        then
            this.jctor1(sprite, image, basicColorArray, animationBehavior)
    member this.jctor1(sprite: Sprite, image: Image, basicColorArray: BasicColor[], animationBehavior: AnimationBehavior) : unit =
        ()
        this.sprite <- sprite
        this.image <- image
        this.basicColorArray <- basicColorArray
        if (this.basicColorArray.Length <> 0) && (this.getSize() <> this.basicColorArray.Length) then
            raise ((new JException((new StringMaker()).append(CommonLabels.getInstance().TOTAL_LABEL).appendint(this.getSize()).append("!=").appendint(this.basicColorArray.Length).ToString())))
        ()
    
    override this.getAnimationSize() : int =
        this.getSize()
    
    override this.setBasicColorP(basicColor: BasicColor) : unit =
        let mutable jflow = 0
        let mutable index : int = 0
        while jflow = 0 && (index < this.basicColorArray.Length) do
            if (JR.same(basicColor, this.basicColorArray.[index])) then
                this.setFrame(index)
                jflow <- 100001
            if jflow = 200001 then jflow <- 0
            if jflow = 0 then index <- index + 1
        if jflow = 100001 then jflow <- 0
    
    override this.getBasicColorP() : BasicColor =
        let mutable jflow = 0
        let mutable jret : BasicColor = Unchecked.defaultof<BasicColor>
        if this.basicColorArray.Length < this.getFrame() then
            jret <- this.basicColorArray.[this.getFrame()]
            jflow <- 1
        else
            jret <- BasicColorFactory.getInstance().WHITE
            jflow <- 1
        jret
    
    abstract paintFrame : graphics: Graphics * frame: int * x: int * y: int -> unit
    default this.paintFrame(graphics: Graphics, frame: int, x: int, y: int) : unit =
        this.setFrame(frame)
        this.sprite.setPosition(x, y)
        this.sprite.paint(graphics)
    
    override this.paintXY(graphics: Graphics, x: int, y: int) : unit =
        this.sprite.setPosition(x, y)
        this.sprite.paint(graphics)
    
    abstract paint : graphics: Graphics -> unit
    default this.paint(graphics: Graphics) : unit =
        this.sprite.paint(graphics)
    
    override this.nextFrame() : unit =
        this.sprite.nextFrame()
    
    override this.previousFrame() : unit =
        this.sprite.prevFrame()
    
    override this.getSize() : int =
        this.sprite.getRawFrameCount()
    
    override this.setFrame(frame: int) : unit =
        this.sprite.setFrame(frame)
    
    override this.getFrame() : int =
        this.sprite.getFrame()
    
    override this.isLastFrame() : bool =
        let mutable jflow = 0
        let mutable jret : bool = Unchecked.defaultof<bool>
        if this.sprite.getFrame() = (this.getSize() - 1) then
            jret <- true
            jflow <- 1
        else
            jret <- false
            jflow <- 1
        jret
    
    abstract getLastFrame : unit -> int
    default this.getLastFrame() : int =
        this.getSize()
    
    override this.setSequence(sequence: int[]) : unit =
        ()
    
    override this.getSequence() : int[] =
        PrimitiveIntUtil.getArrayInstance()
    
    abstract close : unit -> unit
    default this.close() : unit =
        ()
    
    abstract finalize : unit -> unit
    default this.finalize() : unit =
        ()
    interface ColorCompositeInterface with
        member this.getBasicColorP() : BasicColor = this.getBasicColorP()
    interface BasicColorCompositeSetterInterface with
        member this.setBasicColorP(jp0: BasicColor) : unit = this.setBasicColorP(jp0)


