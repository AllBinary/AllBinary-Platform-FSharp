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
type Input =
    [<DefaultValue(false)>] val mutable id : int
    [<DefaultValue(false)>] val mutable name : string
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not Input.jclinitDone then
            Input.jclinitDone <- true
            Input.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_Input() : unit =
        this.name <- StringUtil.getInstance().EMPTY_STRING
        ()
    
    new (id_: int, name: string) as this =
        {  }
        then
            this.jfields_Input()
            this.jctor1(id_, name)
    member this.jctor1(id_: int, name: string) : unit =
        this.setId(id_)
        this.setName(name)
        ()
    
    abstract getId : unit -> int
    default this.getId() : int =
        this.id
    
    member this.setId(key: int) : unit =
        this.id <- key
    
    abstract getName : unit -> string
    default this.getName() : string =
        this.name
    
    member this.setName(keyName: string) : unit =
        this.name <- keyName
    
    override this.ToString() : string =
        let mutable stringBuffer : StringMaker = (new StringMaker())
        ignore (stringBuffer.append("Name: "))
        ignore (stringBuffer.append(this.getName()))
        ignore (stringBuffer.append(" Id: "))
        ignore (stringBuffer.appendint(this.getId()))
        stringBuffer.ToString()


