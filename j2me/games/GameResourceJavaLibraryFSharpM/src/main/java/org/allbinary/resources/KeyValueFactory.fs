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
type KeyValueFactory =
    [<DefaultValue(false)>] val mutable MAP : ABHashtable
    [<DefaultValue(false)>] static val mutable private jcell_instance : KeyValueFactory
    static member instance with get() : KeyValueFactory = (KeyValueFactory.jclinit(); KeyValueFactory.jcell_instance) and set (jvalue: KeyValueFactory) = (KeyValueFactory.jclinit(); KeyValueFactory.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not KeyValueFactory.jclinitDone then
            KeyValueFactory.jclinitDone <- true
            KeyValueFactory.jclinitBody()
    static member private jclinitBody() : unit =
        KeyValueFactory.jcell_instance <- (new KeyValueFactory())
        ()
    new () as this =
        {  }
        then
            this.jfields_KeyValueFactory()
    member this.jfields_KeyValueFactory() : unit =
        this.MAP <- StdUtil.getInstance().createHashtable()
        ()
    
    static member getInstance() : KeyValueFactory =
        KeyValueFactory.instance
    
    abstract get : key: string -> string
    default this.get(key: string) : string =
        let mutable jflow = 0
        let mutable jret : string = Unchecked.defaultof<string>
        if not (this.MAP.containsKey((box (key)))) then
            jret <- key
            jflow <- 1
        if jflow = 0 then
            jret <- (box (this.MAP.get((box (key)))) :?> string)
            jflow <- 1
        jret


