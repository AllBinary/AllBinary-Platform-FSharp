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
type GameGraphicsResourceUtil =
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] val mutable SPRITE : string
    [<DefaultValue(false)>] val mutable QUARTER : string
    [<DefaultValue(false)>] val mutable name : string
    [<DefaultValue(false)>] static val mutable private jcell_instance : obj
    static member instance with get() : obj = (GameGraphicsResourceUtil.jclinit(); GameGraphicsResourceUtil.jcell_instance) and set (jvalue: obj) = (GameGraphicsResourceUtil.jclinit(); GameGraphicsResourceUtil.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not GameGraphicsResourceUtil.jclinitDone then
            GameGraphicsResourceUtil.jclinitDone <- true
            GameGraphicsResourceUtil.jclinitBody()
    static member private jclinitBody() : unit =
        GameGraphicsResourceUtil.jcell_instance <- NullUtil.getInstance().NULL_OBJECT
        ()
    member this.jfields_GameGraphicsResourceUtil() : unit =
        this.logUtil <- LogUtil.getInstance()
        this.SPRITE <- "_sprite"
        this.QUARTER <- "_quarter"
        this.name <- StringUtil.getInstance().EMPTY_STRING
        ()
    
    static member getInstance() : GameGraphicsResourceUtil =
        if (JR.same(GameGraphicsResourceUtil.instance, NullUtil.getInstance().NULL_OBJECT)) then
            GameGraphicsResourceUtil.instance <- (new GameGraphicsResourceUtil())
        (box (GameGraphicsResourceUtil.instance) :?> GameGraphicsResourceUtil)
    
    new () as this =
        {  }
        then
            this.jfields_GameGraphicsResourceUtil()
            this.jctor1()
    member this.jctor1() : unit =
        try
            this.name <- this.getString()
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                let mutable commonStrings : CommonStrings = CommonStrings.getInstance()
                this.logUtil.put(commonStrings.EXCEPTION, this, commonStrings.CONSTRUCTOR, e)
            | _ -> reraise ()
        ()
    
    member this.getString() : string =
        let mutable graphicsFeatureFactory : GraphicsFeatureFactory = GraphicsFeatureFactory.getInstance()
        let mutable graphicsFeature : GraphicsFeature = graphicsFeatureFactory.NONE
        let mutable features : Features = Features.getInstance()
        if features.isFeature(graphicsFeatureFactory.IMAGE_TO_ARRAY_GRAPHICS) then
            graphicsFeature <- graphicsFeatureFactory.IMAGE_TO_ARRAY_GRAPHICS
        elif features.isFeature(graphicsFeatureFactory.SPRITE_FULL_GRAPHICS) then
            graphicsFeature <- graphicsFeatureFactory.SPRITE_FULL_GRAPHICS
        elif features.isFeature(graphicsFeatureFactory.SPRITE_QUARTER_ROTATION_GRAPHICS) then
            graphicsFeature <- graphicsFeatureFactory.SPRITE_QUARTER_ROTATION_GRAPHICS
        elif features.isFeature(graphicsFeatureFactory.IMAGE_ROTATION_ON_THE_FLY) then
            graphicsFeature <- graphicsFeatureFactory.IMAGE_ROTATION_ON_THE_FLY
        this.getStringForFeature(graphicsFeature)
    
    abstract getStringForFeature : graphicsFeature: GraphicsFeature -> string
    default this.getStringForFeature(graphicsFeature: GraphicsFeature) : string =
        let mutable stringBuffer : StringMaker = (new StringMaker())
        let mutable graphicsFeatureFactory : GraphicsFeatureFactory = GraphicsFeatureFactory.getInstance()
        ignore (stringBuffer.delete(0, stringBuffer.length()))
        let mutable features : Features = Features.getInstance()
        if features.isFeature(graphicsFeatureFactory.VECTOR_GRAPHICS) then
            ()
        elif features.isFeature(graphicsFeatureFactory.IMAGE_GRAPHICS) then
            if ((JR.same(graphicsFeature, graphicsFeatureFactory.IMAGE_TO_ARRAY_GRAPHICS))) || ((JR.same(graphicsFeature, graphicsFeatureFactory.IMAGE_ROTATION_ON_THE_FLY))) then
                ()
            elif (JR.same(graphicsFeature, graphicsFeatureFactory.SPRITE_FULL_GRAPHICS)) then
                ignore (stringBuffer.append(this.SPRITE))
            elif (JR.same(graphicsFeature, graphicsFeatureFactory.SPRITE_QUARTER_ROTATION_GRAPHICS)) then
                ignore (stringBuffer.append(this.QUARTER))
                ignore (stringBuffer.append(this.SPRITE))
            else
                raise ((new JException("None/Unknown Sub Image Resource Type Specified")))
        elif OpenGLFeatureUtil.getInstance().isAnyThreed() then
            ignore (stringBuffer.append(CanvasStrings.getInstance().OBJ_MODEL))
        else
            raise ((new JException("None/Unknown Main Image Resource Type Specified")))
        stringBuffer.ToString()
    
    abstract getName : unit -> string
    default this.getName() : string =
        this.name


