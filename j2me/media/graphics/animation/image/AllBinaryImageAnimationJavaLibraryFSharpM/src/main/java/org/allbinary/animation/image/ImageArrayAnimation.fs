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
type ImageArrayAnimation =
    inherit IndexedAnimation
    [<DefaultValue(false)>] val mutable imageArray : Image[]
    [<DefaultValue(false)>] val mutable totalFrames : int
    [<DefaultValue(false)>] val mutable circularIndexUtil : CircularIndexUtil
    [<DefaultValue(false)>] val mutable anchor : int
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not ImageArrayAnimation.jclinitDone then
            ImageArrayAnimation.jclinitDone <- true
            ImageArrayAnimation.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_ImageArrayAnimation() : unit =
        this.imageArray <- NullImage.NULL_IMAGE_ARRAY
        this.circularIndexUtil <- CircularIndexUtil.NULL_CIRCULAR_INDEX_UTIL
        this.anchor <- Anchor.TOP_LEFT
        ()
    
    new (imageArray: Image[], animationBehavior: AnimationBehavior) as this =
        { inherit IndexedAnimation(animationBehavior) }
        then
            this.jfields_ImageArrayAnimation()
            this.jctor1(imageArray, animationBehavior)
    member this.jctor1(imageArray: Image[], animationBehavior: AnimationBehavior) : unit =
        ()
        this.setImageArray(imageArray)
        ()
    
    override this.getAnimationSize() : int =
        this.getSize()
    
    override this.nextFrame() : unit =
        ignore (this.circularIndexUtil.next())
    
    override this.previousFrame() : unit =
        ignore (this.circularIndexUtil.previous())
    
    override this.setFrame(index: int) : unit =
        this.circularIndexUtil.setIndex(index)
    
    override this.getFrame() : int =
        this.circularIndexUtil.getIndex()
    
    override this.getSize() : int =
        this.totalFrames
    
    override this.setSequence(sequence: int[]) : unit =
        ()
    
    override this.getSequence() : int[] =
        PrimitiveIntUtil.getArrayInstance()
    
    abstract getImage : index: int -> Image
    default this.getImage(index: int) : Image =
        this.imageArray.[index]
    
    abstract getImageArray : unit -> Image[]
    default this.getImageArray() : Image[] =
        this.imageArray
    
    abstract setImageArray : imageArray: Image[] -> unit
    default this.setImageArray(imageArray: Image[]) : unit =
        this.imageArray <- imageArray
        this.totalFrames <- imageArray.Length
        this.circularIndexUtil <- CircularIndexUtil.createInstance(this.totalFrames)
    
    override this.paintXY(graphics: Graphics, x: int, y: int) : unit =
        graphics.drawImage(this.imageArray.[this.circularIndexUtil.getIndex()], x, y, this.anchor)


