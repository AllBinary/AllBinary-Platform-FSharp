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
type KeySpecFactory =
    [<DefaultValue(false)>] val mutable DES : string
    [<DefaultValue(false)>] val mutable DESEDE : string
    [<DefaultValue(false)>] val mutable BLOWFISH : string
    [<DefaultValue(false)>] static val mutable private jcell_instance : KeySpecFactory
    static member instance with get() : KeySpecFactory = (KeySpecFactory.jclinit(); KeySpecFactory.jcell_instance) and set (jvalue: KeySpecFactory) = (KeySpecFactory.jclinit(); KeySpecFactory.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not KeySpecFactory.jclinitDone then
            KeySpecFactory.jclinitDone <- true
            KeySpecFactory.jclinitBody()
    static member private jclinitBody() : unit =
        KeySpecFactory.jcell_instance <- (new KeySpecFactory())
        ()
    member this.jfields_KeySpecFactory() : unit =
        this.DES <- "DES"
        this.DESEDE <- "DESede"
        this.BLOWFISH <- "Blowfish"
        ()
    
    static member getInstance_jstatic() : KeySpecFactory =
        KeySpecFactory.instance
    
    new () as this =
        {  }
        then
            this.jfields_KeySpecFactory()
    
    abstract getInstance : algorithm: string * keyData: sbyte[] -> KeySpec
    default this.getInstance(algorithm: string, keyData: sbyte[]) : KeySpec =
        let mutable jflow = 0
        let mutable jret : KeySpec = Unchecked.defaultof<KeySpec>
        try
            let mutable tsUtil : TsUtil = TsUtil.getInstance()
            if tsUtil.compareTo(algorithm, this.DES) = 0 then
                jret <- (new DESKeySpec(keyData))
                jflow <- 1
            elif tsUtil.compareTo(algorithm, this.DESEDE) = 0 then
                jret <- (new DESedeKeySpec(keyData))
                jflow <- 1
            else
                raise ((new JRuntimeException()))
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                let mutable commonStrings : CommonStrings = CommonStrings.getInstance()
                PreLogUtil.putOE(commonStrings.EXCEPTION, this, commonStrings.GET_INSTANCE, e)
                raise ((new JRuntimeException()))
            | _ -> reraise ()
        jret


