namespace rec AllBinary

// Generated Code Do Not Modify
(*
 * 
 * AllBinary Open License Version 1 
 * Copyright (c) 2022 AllBinary 
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
type SpriteFactory =
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] static val mutable private jcell_instance : SpriteFactory
    static member instance with get() : SpriteFactory = (SpriteFactory.jclinit(); SpriteFactory.jcell_instance) and set (jvalue: SpriteFactory) = (SpriteFactory.jclinit(); SpriteFactory.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not SpriteFactory.jclinitDone then
            SpriteFactory.jclinitDone <- true
            SpriteFactory.jclinitBody()
    static member private jclinitBody() : unit =
        SpriteFactory.jcell_instance <- (new SpriteFactory())
        ()
    new () as this =
        {  }
        then
            this.jfields_SpriteFactory()
    member this.jfields_SpriteFactory() : unit =
        this.logUtil <- LogUtil.getInstance()
        ()
    
    static member getInstance() : SpriteFactory =
        SpriteFactory.instance
    
    abstract createSprite : image: Image * frameWidth: int * frameHeight: int -> Sprite
    default this.createSprite(image: Image, frameWidth: int, frameHeight: int) : Sprite =
        (new Sprite(image, frameWidth, frameHeight))
    interface SpriteFactoryInterface with
        member this.createSprite(jp0: Image, jp1: int, jp2: int) : Sprite = this.createSprite(jp0, jp1, jp2)


