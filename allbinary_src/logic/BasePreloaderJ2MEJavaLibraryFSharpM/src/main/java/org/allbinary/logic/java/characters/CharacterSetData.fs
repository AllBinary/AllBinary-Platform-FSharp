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
type CharacterSetData =
    [<DefaultValue(false)>] val mutable US_ASCII : string
    [<DefaultValue(false)>] val mutable ISO_8859_1 : string
    [<DefaultValue(false)>] val mutable UTF_8 : string
    [<DefaultValue(false)>] val mutable UTF_16 : string
    [<DefaultValue(false)>] val mutable UTF_16BE : string
    [<DefaultValue(false)>] val mutable UTF_16LE : string
    [<DefaultValue(false)>] static val mutable private jcell_instance : CharacterSetData
    static member instance with get() : CharacterSetData = (CharacterSetData.jclinit(); CharacterSetData.jcell_instance) and set (jvalue: CharacterSetData) = (CharacterSetData.jclinit(); CharacterSetData.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not CharacterSetData.jclinitDone then
            CharacterSetData.jclinitDone <- true
            CharacterSetData.jclinitBody()
    static member private jclinitBody() : unit =
        CharacterSetData.jcell_instance <- (new CharacterSetData())
        ()
    member this.jfields_CharacterSetData() : unit =
        this.US_ASCII <- "US-ASCII"
        this.ISO_8859_1 <- "ISO-8859-1"
        this.UTF_8 <- "UTF-8"
        this.UTF_16 <- "UTF-16"
        this.UTF_16BE <- "UTF-16BE"
        this.UTF_16LE <- "UTF-16LE"
        ()
    
    static member getInstance() : CharacterSetData =
        CharacterSetData.instance
    
    new () as this =
        {  }
        then
            this.jfields_CharacterSetData()


