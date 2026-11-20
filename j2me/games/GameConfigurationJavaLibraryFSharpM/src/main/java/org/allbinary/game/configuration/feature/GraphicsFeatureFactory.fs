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
type GraphicsFeatureFactory =
    [<DefaultValue(false)>] val mutable NONE : GraphicsFeature
    [<DefaultValue(false)>] val mutable TRANSPARENT_IMAGE_CREATION : GraphicsFeature
    [<DefaultValue(false)>] val mutable IMAGE_GRAPHICS : GraphicsFeature
    [<DefaultValue(false)>] val mutable IMAGE_ROTATION_ON_THE_FLY : GraphicsFeature
    [<DefaultValue(false)>] val mutable IMAGE_TO_ARRAY_GRAPHICS : GraphicsFeature
    [<DefaultValue(false)>] val mutable SPRITE_QUARTER_ROTATION_GRAPHICS : GraphicsFeature
    [<DefaultValue(false)>] val mutable SPRITE_FULL_GRAPHICS : GraphicsFeature
    [<DefaultValue(false)>] val mutable VECTOR_GRAPHICS : GraphicsFeature
    [<DefaultValue(false)>] val mutable VECTOR_TO_IMAGE_GRAPHICS : GraphicsFeature
    [<DefaultValue(false)>] static val mutable private jcell_instance : GraphicsFeatureFactory
    static member instance with get() : GraphicsFeatureFactory = (GraphicsFeatureFactory.jclinit(); GraphicsFeatureFactory.jcell_instance) and set (jvalue: GraphicsFeatureFactory) = (GraphicsFeatureFactory.jclinit(); GraphicsFeatureFactory.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not GraphicsFeatureFactory.jclinitDone then
            GraphicsFeatureFactory.jclinitDone <- true
            GraphicsFeatureFactory.jclinitBody()
    static member private jclinitBody() : unit =
        GraphicsFeatureFactory.jcell_instance <- (new GraphicsFeatureFactory())
        ()
    member this.jfields_GraphicsFeatureFactory() : unit =
        this.NONE <- (new GraphicsFeature(StringUtil.getInstance().NULL_STRING))
        this.TRANSPARENT_IMAGE_CREATION <- (new GraphicsFeature("Transparent Image Creation"))
        this.IMAGE_GRAPHICS <- (new GraphicsFeature("Image Graphics"))
        this.IMAGE_ROTATION_ON_THE_FLY <- (new GraphicsFeature("Image Rotated On The Fly"))
        this.IMAGE_TO_ARRAY_GRAPHICS <- (new GraphicsFeature("Image To Array Graphics"))
        this.SPRITE_QUARTER_ROTATION_GRAPHICS <- (new GraphicsFeature("Sprite Quarter Rotation Graphics"))
        this.SPRITE_FULL_GRAPHICS <- (new GraphicsFeature("Sprite Full Rotation Graphics"))
        this.VECTOR_GRAPHICS <- (new GraphicsFeature("BasicArrayList Graphics"))
        this.VECTOR_TO_IMAGE_GRAPHICS <- (new GraphicsFeature("BasicArrayList To Image Graphics"))
        ()
    
    static member getInstance() : GraphicsFeatureFactory =
        GraphicsFeatureFactory.instance
    
    new () as this =
        {  }
        then
            this.jfields_GraphicsFeatureFactory()


