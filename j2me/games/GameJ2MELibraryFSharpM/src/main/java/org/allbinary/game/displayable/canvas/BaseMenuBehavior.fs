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
type BaseMenuBehavior =
    [<DefaultValue(false)>] static val mutable private jcell_instance : BaseMenuBehavior
    static member instance with get() : BaseMenuBehavior = (BaseMenuBehavior.jclinit(); BaseMenuBehavior.jcell_instance) and set (jvalue: BaseMenuBehavior) = (BaseMenuBehavior.jclinit(); BaseMenuBehavior.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not BaseMenuBehavior.jclinitDone then
            BaseMenuBehavior.jclinitDone <- true
            BaseMenuBehavior.jclinitBody()
    static member private jclinitBody() : unit =
        BaseMenuBehavior.jcell_instance <- (new BaseMenuBehavior())
        ()
    new () =
        {  }
    
    static member getInstance() : BaseMenuBehavior =
        BaseMenuBehavior.instance
    
    abstract onDisplayChangeEvent : allBinaryGameCanvas: AllBinaryGameCanvas * displayChangeEvent: DisplayChangeEvent -> unit
    default this.onDisplayChangeEvent(allBinaryGameCanvas: AllBinaryGameCanvas, displayChangeEvent: DisplayChangeEvent) : unit =
        ()
    
    abstract initSpecialPaint : allBinaryGameCanvas: AllBinaryGameCanvas -> unit
    default this.initSpecialPaint(allBinaryGameCanvas: AllBinaryGameCanvas) : unit =
        allBinaryGameCanvas.setNonBotPaintableP(NullPaintable.getInstance())
    
    abstract initMenu : allBinaryGameCanvas: AllBinaryGameCanvas -> unit
    default this.initMenu(allBinaryGameCanvas: AllBinaryGameCanvas) : unit =
        ()
    
    abstract updateMenu : allBinaryGameCanvas: AllBinaryGameCanvas -> unit
    default this.updateMenu(allBinaryGameCanvas: AllBinaryGameCanvas) : unit =
        ()
    
    abstract popupMenu : allBinaryGameCanvas: AllBinaryGameCanvas -> unit
    default this.popupMenu(allBinaryGameCanvas: AllBinaryGameCanvas) : unit =
        ()
    
    abstract closeMenu : allBinaryGameCanvas: AllBinaryGameCanvas -> unit
    default this.closeMenu(allBinaryGameCanvas: AllBinaryGameCanvas) : unit =
        ()


