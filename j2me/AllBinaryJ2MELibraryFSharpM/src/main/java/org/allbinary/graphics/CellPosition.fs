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
type CellPosition =
    inherit V
    [<DefaultValue(false)>] val mutable id : int
    [<DefaultValue(false)>] val mutable column : int
    [<DefaultValue(false)>] val mutable row : int
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not CellPosition.jclinitDone then
            CellPosition.jclinitDone <- true
            CellPosition.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (column: int, row: int, columns: int, rows: int) as this =
        { inherit V() }
        then
            this.jctor1(column, row, columns, rows)
    member this.jctor1(column: int, row: int, columns: int, rows: int) : unit =
        this.column <- column
        this.row <- row
        this.id <- (row * columns) + column
        ()
    
    abstract getColumn : unit -> int
    default this.getColumn() : int =
        this.column
    
    abstract getRow : unit -> int
    default this.getRow() : int =
        this.row
    
    override this.ToString() : string =
        CellPosition.toStringColRow(this.getColumn(), this.getRow())
    
    static member toStringCellPosition(basicGeographicMapCellPosition: CellPosition) : string =
        CellPosition.toStringColRow(basicGeographicMapCellPosition.getColumn(), basicGeographicMapCellPosition.getRow())
    
    static member toStringColRow(i_column: int, i_row: int) : string =
        let mutable stringBuffer : StringMaker = (new StringMaker())
        let mutable commonSeps : CommonSeps = CommonSeps.getInstance()
        ignore (stringBuffer.append(commonSeps.PARENTHESIS_OPEN))
        ignore (stringBuffer.appendint(i_column))
        ignore (stringBuffer.append(commonSeps.COMMA))
        ignore (stringBuffer.appendint(i_row))
        ignore (stringBuffer.append(commonSeps.PARENTHESIS_CLOSE))
        stringBuffer.ToString()
    
    override this.getId() : int =
        this.id


