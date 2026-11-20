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
type BasicGameResources =
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] val mutable RESOURCE : string
    [<DefaultValue(false)>] val mutable RESOURCE_DESTROY : string
    [<DefaultValue(false)>] static val mutable private jcell_stringBuffer : StringMaker
    static member stringBuffer with get() : StringMaker = (BasicGameResources.jclinit(); BasicGameResources.jcell_stringBuffer) and set (jvalue: StringMaker) = (BasicGameResources.jclinit(); BasicGameResources.jcell_stringBuffer <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not BasicGameResources.jclinitDone then
            BasicGameResources.jclinitDone <- true
            BasicGameResources.jclinitBody()
    static member private jclinitBody() : unit =
        BasicGameResources.jcell_stringBuffer <- (new StringMaker())
        ()
    member this.jfields_BasicGameResources() : unit =
        this.logUtil <- LogUtil.getInstance()
        this.RESOURCE <- StringUtil.getInstance().EMPTY_STRING
        this.RESOURCE_DESTROY <- StringUtil.getInstance().EMPTY_STRING
        ()
    
    new () as this =
        {  }
        then
            this.jfields_BasicGameResources()
    
    abstract init : ROOT: string * SIZE: string[] -> unit
    default this.init(ROOT: string, SIZE: string[]) : unit =
        try
            let mutable scale : int = GameConfigurationCentral.getInstance().SCALE.getValue().intValue()
            if (scale > 1) && ((scale - 1) < SIZE.Length) then
                this.append(ROOT, SIZE.[scale - 1])
            else
                raise ((new JException((new StringMaker()).append("Invalid Value: ").appendint(scale).ToString())))
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                let mutable commonStrings : CommonStrings = CommonStrings.getInstance()
                this.logUtil.put(commonStrings.EXCEPTION, this, commonStrings.INIT, e)
            | _ -> reraise ()
    
    abstract append : ROOT: string * sizeString: string -> unit
    default this.append(ROOT: string, sizeString: string) : unit =
        let mutable DESTROY : string = "_destroy"
        let mutable string_ : string = this.getString()
        ignore (BasicGameResources.stringBuffer.delete(0, BasicGameResources.stringBuffer.length()))
        ignore (BasicGameResources.stringBuffer.append(ROOT))
        ignore (BasicGameResources.stringBuffer.append(string_))
        ignore (BasicGameResources.stringBuffer.append(sizeString))
        this.RESOURCE <- BasicGameResources.stringBuffer.ToString()
        ignore (BasicGameResources.stringBuffer.delete(0, BasicGameResources.stringBuffer.length()))
        ignore (BasicGameResources.stringBuffer.append(ROOT))
        ignore (BasicGameResources.stringBuffer.append(DESTROY))
        ignore (BasicGameResources.stringBuffer.append(string_))
        ignore (BasicGameResources.stringBuffer.append(sizeString))
        this.RESOURCE_DESTROY <- BasicGameResources.stringBuffer.ToString()
    
    abstract getString : unit -> string
    default this.getString() : string =
        GameGraphicsResourceUtil.getInstance().getName()


