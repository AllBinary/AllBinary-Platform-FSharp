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
type FormUtil =
    [<DefaultValue(false)>] static val mutable private jcell_instance : FormUtil
    static member instance with get() : FormUtil = (FormUtil.jclinit(); FormUtil.jcell_instance) and set (jvalue: FormUtil) = (FormUtil.jclinit(); FormUtil.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not FormUtil.jclinitDone then
            FormUtil.jclinitDone <- true
            FormUtil.jclinitBody()
    static member private jclinitBody() : unit =
        FormUtil.jcell_instance <- (new FormUtil())
        ()
    new () =
        {  }
    
    static member getInstance() : FormUtil =
        FormUtil.instance
    
    abstract createFormRectangle : unit -> Rectangle
    default this.createFormRectangle() : Rectangle =
        let mutable displayInfo : DisplayInfoSingleton = DisplayInfoSingleton.getInstance()
        let mutable pointFactory : PointFactory = PointFactory.getInstance()
        let mutable rectangle : Rectangle = (new Rectangle(pointFactory.createXY(30, 10), (displayInfo.getLastWidth() - 30), (displayInfo.getLastHeight() - 35)))
        rectangle


