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
type InGameMenuBehavior =
    inherit BaseMenuBehavior
    [<DefaultValue(false)>] static val mutable private jcell_instanceC : InGameMenuBehavior
    static member instanceC with get() : InGameMenuBehavior = (InGameMenuBehavior.jclinit(); InGameMenuBehavior.jcell_instanceC) and set (jvalue: InGameMenuBehavior) = (InGameMenuBehavior.jclinit(); InGameMenuBehavior.jcell_instanceC <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not InGameMenuBehavior.jclinitDone then
            InGameMenuBehavior.jclinitDone <- true
            InGameMenuBehavior.jclinitBody()
    static member private jclinitBody() : unit =
        InGameMenuBehavior.jcell_instanceC <- (new InGameMenuBehavior())
        ()
    new () =
        { inherit BaseMenuBehavior() }
    
    static member getInstance() : InGameMenuBehavior =
        InGameMenuBehavior.instanceC
    
    override this.onDisplayChangeEvent(allBinaryGameCanvas: AllBinaryGameCanvas, displayChangeEvent: DisplayChangeEvent) : unit =
        allBinaryGameCanvas.updateMenuFromEvent(displayChangeEvent)
    
    override this.initSpecialPaint(allBinaryGameCanvas: AllBinaryGameCanvas) : unit =
        allBinaryGameCanvas.setNonBotPaintableP((new GameCanvasNonBotPaintable(allBinaryGameCanvas)))
    
    override this.initMenu(allBinaryGameCanvas: AllBinaryGameCanvas) : unit =
        allBinaryGameCanvas.initMenu2()
    
    override this.updateMenu(allBinaryGameCanvas: AllBinaryGameCanvas) : unit =
        allBinaryGameCanvas.initMenu2()
    
    override this.popupMenu(allBinaryGameCanvas: AllBinaryGameCanvas) : unit =
        allBinaryGameCanvas.popupMenu2()
    
    override this.closeMenu(allBinaryGameCanvas: AllBinaryGameCanvas) : unit =
        allBinaryGameCanvas.closeMenu2()


