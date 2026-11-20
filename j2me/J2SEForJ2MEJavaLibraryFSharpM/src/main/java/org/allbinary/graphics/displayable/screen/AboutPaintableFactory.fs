namespace rec AllBinary

// Generated Code Do Not Modify
(*
 *
 * AllBinary Open License Version 1
 * Copyright (c) 2022 AllBinary
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
type AboutPaintableFactory =
    [<DefaultValue(false)>] val mutable paintableArray : Paintable[]
    [<DefaultValue(false)>] static val mutable private jcell_instance : AboutPaintableFactory
    static member instance with get() : AboutPaintableFactory = (AboutPaintableFactory.jclinit(); AboutPaintableFactory.jcell_instance) and set (jvalue: AboutPaintableFactory) = (AboutPaintableFactory.jclinit(); AboutPaintableFactory.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not AboutPaintableFactory.jclinitDone then
            AboutPaintableFactory.jclinitDone <- true
            AboutPaintableFactory.jclinitBody()
    static member private jclinitBody() : unit =
        AboutPaintableFactory.jcell_instance <- (new AboutPaintableFactory())
        ()
    member this.jfields_AboutPaintableFactory() : unit =
        this.paintableArray <- ([| NullPaintable.getInstance() |] : Paintable[])
        ()
    
    static member getInstance() : AboutPaintableFactory =
        AboutPaintableFactory.instance
    
    new () as this =
        {  }
        then
            this.jfields_AboutPaintableFactory()
            this.jctor1()
    member this.jctor1() : unit =
        let mutable INFO : string[] = ([| "Built with the"; "AllBinary Platform"; StringUtil.getInstance().EMPTY_STRING; "Comments or Questions:"; "support@allbinary.com" |] : string[])
        let mutable DEVELOPERS : string[] = ([| "Developed By:"; "Travis Berthelot" |] : string[])
        this.paintableArray <- AboutPaintable.getInstance(INFO, DEVELOPERS).getPaintableArrayInstance()
        ()


