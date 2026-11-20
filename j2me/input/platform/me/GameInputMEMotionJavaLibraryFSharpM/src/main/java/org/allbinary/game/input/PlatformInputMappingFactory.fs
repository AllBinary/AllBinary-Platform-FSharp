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
type PlatformInputMappingFactory =
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] val mutable inputToGameKeyMapping : PersistentInputMapping
    [<DefaultValue(false)>] static val mutable private jcell_instance : PlatformInputMappingFactory
    static member instance with get() : PlatformInputMappingFactory = (PlatformInputMappingFactory.jclinit(); PlatformInputMappingFactory.jcell_instance) and set (jvalue: PlatformInputMappingFactory) = (PlatformInputMappingFactory.jclinit(); PlatformInputMappingFactory.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not PlatformInputMappingFactory.jclinitDone then
            PlatformInputMappingFactory.jclinitDone <- true
            PlatformInputMappingFactory.jclinitBody()
    static member private jclinitBody() : unit =
        PlatformInputMappingFactory.jcell_instance <- (new PlatformInputMappingFactory())
        ()
    new () as this =
        {  }
        then
            this.jfields_PlatformInputMappingFactory()
    member this.jfields_PlatformInputMappingFactory() : unit =
        this.logUtil <- LogUtil.getInstance()
        this.inputToGameKeyMapping <- PersistentInputMapping.getNullInstance()
        ()
    
    static member getInstance() : PlatformInputMappingFactory =
        PlatformInputMappingFactory.instance
    
    abstract getPersistentInputMappingInstance : unit -> PersistentInputMapping
    default this.getPersistentInputMappingInstance() : PersistentInputMapping =
        try
            if (JR.same(this.inputToGameKeyMapping, PersistentInputMapping.getNullInstance())) then
                this.inputToGameKeyMapping <- (new MotionJ2MEGameInputMapping())
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                let mutable commonStrings : CommonStrings = CommonStrings.getInstance()
                this.logUtil.put(commonStrings.EXCEPTION, this, commonStrings.GET_INSTANCE, e)
            | _ -> reraise ()
        this.inputToGameKeyMapping


