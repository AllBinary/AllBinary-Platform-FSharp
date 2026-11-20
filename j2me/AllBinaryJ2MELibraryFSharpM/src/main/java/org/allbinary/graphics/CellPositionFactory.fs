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
type CellPositionFactory =
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] val mutable NONE : CellPosition
    [<DefaultValue(false)>] val mutable cellPositionArray : CellPosition[][]
    [<DefaultValue(false)>] val mutable columns : int
    [<DefaultValue(false)>] val mutable rows : int
    [<DefaultValue(false)>] static val mutable private jcell_SINGLETON : CellPositionFactory
    static member SINGLETON with get() : CellPositionFactory = (CellPositionFactory.jclinit(); CellPositionFactory.jcell_SINGLETON) and set (jvalue: CellPositionFactory) = (CellPositionFactory.jclinit(); CellPositionFactory.jcell_SINGLETON <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not CellPositionFactory.jclinitDone then
            CellPositionFactory.jclinitDone <- true
            CellPositionFactory.jclinitBody()
    static member private jclinitBody() : unit =
        CellPositionFactory.jcell_SINGLETON <- (new CellPositionFactory())
        ()
    member this.jfields_CellPositionFactory() : unit =
        this.logUtil <- LogUtil.getInstance()
        this.NONE <- (new CellPosition(-1, -1, -1, -1))
        this.cellPositionArray <- (JR.newArray2<CellPosition>(0, 0))
        ()
    
    static member getInstance() : CellPositionFactory =
        CellPositionFactory.SINGLETON
    
    new () as this =
        {  }
        then
            this.jfields_CellPositionFactory()
    
    abstract init : columns: int * rows: int -> unit
    default this.init(columns: int, rows: int) : unit =
        let mutable commonStrings : CommonStrings = CommonStrings.getInstance()
        let mutable stringBuffer : StringMaker = (new StringMaker())
        ignore (stringBuffer.append("Init: columns: "))
        ignore (stringBuffer.appendint(columns))
        ignore (stringBuffer.append(" rows: "))
        ignore (stringBuffer.appendint(rows))
        this.logUtil.putF(stringBuffer.ToString(), this, commonStrings.INIT)
        this.cellPositionArray <- (JR.newArray2<CellPosition>(columns, rows))
        this.columns <- columns
        this.rows <- rows
        let mutable column : int = 0
        while column < columns do
            let mutable row : int = 0
            while row < rows do
                ignore (this.createInstance(column, row))
                row <- row + 1
            column <- column + 1
    
    abstract getInstanceColRow : i_column: int * i_row: int -> CellPosition
    default this.getInstanceColRow(i_column: int, i_row: int) : CellPosition =
        let mutable jflow = 0
        let mutable jret : CellPosition = Unchecked.defaultof<CellPosition>
        try
            jret <- this.cellPositionArray.[i_column].[i_row]
            jflow <- 1
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                let mutable commonStrings : CommonStrings = CommonStrings.getInstance()
                this.logUtil.put((new StringMaker()).append("columns: ").appendint(this.getColumns()).append(" rows: ").appendint(this.getRows()).append(" col: ").appendint(i_column).append(" row: ").appendint(i_row).ToString(), this, commonStrings.GET_INSTANCE, e)
                jret <- this.NONE
                jflow <- 1
            | _ -> reraise ()
        jret
    
    abstract createInstance : i_column: int * i_row: int -> CellPosition
    default this.createInstance(i_column: int, i_row: int) : CellPosition =
        let mutable cellPositionCanBeNull : CellPosition = this.cellPositionArray.[i_column].[i_row]
        if (JR.same(cellPositionCanBeNull, null)) then
            cellPositionCanBeNull <- (new CellPosition(i_column, i_row, this.columns, this.rows))
            this.cellPositionArray.[i_column].[i_row] <- cellPositionCanBeNull
        cellPositionCanBeNull
    
    abstract getColumns : unit -> int
    default this.getColumns() : int =
        this.columns
    
    abstract getRows : unit -> int
    default this.getRows() : int =
        this.rows


