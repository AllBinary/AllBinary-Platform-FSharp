namespace rec AllBinary

// Generated Code Do Not Modify

[<AllowNullLiteral>]
type KotlinUtil =
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not KotlinUtil.jclinitDone then
            KotlinUtil.jclinitDone <- true
            KotlinUtil.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    new () =
        {  }
    
    static member isKotlin() : bool =
        false
    
    static member getShortName() : string =
        StringUtil.getInstance().EMPTY_STRING


