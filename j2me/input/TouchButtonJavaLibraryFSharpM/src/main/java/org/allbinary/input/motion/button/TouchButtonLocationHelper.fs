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
type TouchButtonLocationHelper =
    [<DefaultValue(false)>] val mutable totalColumns : int
    [<DefaultValue(false)>] val mutable totalRows : int
    [<DefaultValue(false)>] val mutable columnsRemainder : int
    [<DefaultValue(false)>] val mutable rowsRemainder : int
    [<DefaultValue(false)>] val mutable columnsRemainderHalf : int
    [<DefaultValue(false)>] val mutable rowsRemainderHalf : int
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not TouchButtonLocationHelper.jclinitDone then
            TouchButtonLocationHelper.jclinitDone <- true
            TouchButtonLocationHelper.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new () as this =
        {  }
        then
            this.jctor1()
    member this.jctor1() : unit =
        let mutable buttonSize : int = CommonButtons.getInstance().STANDARD_BUTTON_SIZE
        let mutable displayInfo : DisplayInfoSingleton = DisplayInfoSingleton.getInstance()
        this.totalColumns <- JMath.round((float32 (displayInfo.getLastWidth()) / float32 (buttonSize)))
        this.totalRows <- JMath.round((float32 (displayInfo.getLastHeight()) / float32 (buttonSize)))
        this.columnsRemainder <- displayInfo.getLastWidth() % buttonSize
        this.columnsRemainderHalf <- (this.columnsRemainder >>> 1)
        this.rowsRemainder <- displayInfo.getLastHeight() % buttonSize
        this.rowsRemainderHalf <- (this.rowsRemainder >>> 1)
        ()
    
    abstract getTotalColumns : unit -> int
    default this.getTotalColumns() : int =
        this.totalColumns
    
    abstract getTotalRows : unit -> int
    default this.getTotalRows() : int =
        this.totalRows
    
    abstract getColumnsRemainder : unit -> int
    default this.getColumnsRemainder() : int =
        this.columnsRemainder
    
    abstract getRowsRemainder : unit -> int
    default this.getRowsRemainder() : int =
        this.rowsRemainder
    
    abstract getColumnsRemainderHalf : unit -> int
    default this.getColumnsRemainderHalf() : int =
        this.columnsRemainderHalf
    
    abstract getRowsRemainderHalf : unit -> int
    default this.getRowsRemainderHalf() : int =
        this.rowsRemainderHalf
    
    override this.ToString() : string =
        let mutable stringBuffer : StringMaker = (new StringMaker())
        ignore (stringBuffer.append("totalColumns: "))
        ignore (stringBuffer.appendint(this.totalColumns))
        ignore (stringBuffer.append(" totalRows: "))
        ignore (stringBuffer.appendint(this.totalRows))
        ignore (stringBuffer.append(" columnsRemainder: "))
        ignore (stringBuffer.appendint(this.columnsRemainder))
        ignore (stringBuffer.append(" rowsRemainder: "))
        ignore (stringBuffer.appendint(this.rowsRemainder))
        ignore (stringBuffer.append(" columnsRemainderHalf: "))
        ignore (stringBuffer.appendint(this.columnsRemainderHalf))
        ignore (stringBuffer.append(" rowsRemainderHalf: "))
        ignore (stringBuffer.appendint(this.rowsRemainderHalf))
        stringBuffer.ToString()


