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
type PlatformFormInputMappingFactory =
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] val mutable inputToGameKeyMapping : InputToGameKeyMapping
    [<DefaultValue(false)>] static val mutable private jcell_instance : obj
    static member instance with get() : obj = (PlatformFormInputMappingFactory.jclinit(); PlatformFormInputMappingFactory.jcell_instance) and set (jvalue: obj) = (PlatformFormInputMappingFactory.jclinit(); PlatformFormInputMappingFactory.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not PlatformFormInputMappingFactory.jclinitDone then
            PlatformFormInputMappingFactory.jclinitDone <- true
            PlatformFormInputMappingFactory.jclinitBody()
    static member private jclinitBody() : unit =
        PlatformFormInputMappingFactory.jcell_instance <- NullUtil.getInstance().NULL_OBJECT
        ()
    new () as this =
        {  }
        then
            this.jfields_PlatformFormInputMappingFactory()
    member this.jfields_PlatformFormInputMappingFactory() : unit =
        this.logUtil <- LogUtil.getInstance()
        this.inputToGameKeyMapping <- InputToGameKeyMapping.getNullInstance()
        ()
    
    static member getInstance() : PlatformFormInputMappingFactory =
        if (JR.same(PlatformFormInputMappingFactory.instance, NullUtil.getInstance().NULL_OBJECT)) then
            PlatformFormInputMappingFactory.instance <- (new PlatformFormInputMappingFactory())
        (box (PlatformFormInputMappingFactory.instance) :?> PlatformFormInputMappingFactory)
    
    abstract getOrCreate : unit -> InputToGameKeyMapping
    default this.getOrCreate() : InputToGameKeyMapping =
        try
            if (JR.same(this.inputToGameKeyMapping, InputToGameKeyMapping.getNullInstance())) then
                let mutable pcKeyFactory : PCKeyFactory = PCKeyFactory.getInstance()
                let mutable inputToGameKeyMapping : InputToGameKeyMapping = (new InputToGameKeyMapping())
                let mutable gameKeyFactory : GameKeyFactory = GameKeyFactory.getInstance()
                let mutable basicTouchInputFactory : BasicTouchInputFactory = BasicTouchInputFactory.getInstance()
                inputToGameKeyMapping.add(gameKeyFactory.UP, pcKeyFactory.DPAD_UP)
                inputToGameKeyMapping.add(gameKeyFactory.DOWN, pcKeyFactory.DPAD_DOWN)
                inputToGameKeyMapping.add(gameKeyFactory.LEFT, pcKeyFactory.DPAD_LEFT)
                inputToGameKeyMapping.add(gameKeyFactory.RIGHT, pcKeyFactory.DPAD_RIGHT)
                inputToGameKeyMapping.add(gameKeyFactory.KEY_NUM1, pcKeyFactory.ENTER)
                inputToGameKeyMapping.add(gameKeyFactory.UP, basicTouchInputFactory.UP)
                inputToGameKeyMapping.add(gameKeyFactory.LEFT, basicTouchInputFactory.LEFT)
                inputToGameKeyMapping.add(gameKeyFactory.RIGHT, basicTouchInputFactory.RIGHT)
                inputToGameKeyMapping.add(gameKeyFactory.DOWN, basicTouchInputFactory.DOWN)
                this.inputToGameKeyMapping <- inputToGameKeyMapping
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                let mutable commonStrings : CommonStrings = CommonStrings.getInstance()
                this.logUtil.put(commonStrings.EXCEPTION, this, commonStrings.GET_INSTANCE, e)
            | _ -> reraise ()
        this.inputToGameKeyMapping


