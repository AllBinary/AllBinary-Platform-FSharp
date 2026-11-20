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
type SelectableTextItem =
    inherit ABTextItem
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not SelectableTextItem.jclinitDone then
            SelectableTextItem.jclinitDone <- true
            SelectableTextItem.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (label: string, layout: int, altText: string, backgroundBasicColor: BasicColor, foregroundBasicColor: BasicColor) =
        { inherit ABTextItem(label, layout, altText, backgroundBasicColor, foregroundBasicColor) }
    
    override this.isFocusable() : bool =
        true
    
    override this.paintXY(graphics: Graphics, x: int, y: int) : unit =
        this.myFontProcessor.process_(graphics)
        let mutable stringComponent : ABStringComponent = this.getLabelStringComponent()
        if not (JR.same(stringComponent, null)) then
            graphics.setColor(stringComponent.getForegroundBasicColor().intValue())
        graphics.drawString(this.getLabel(), (x + 2), y, 0)


