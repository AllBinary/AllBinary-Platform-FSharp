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
type HighScores =
    [<DefaultValue(false)>] val mutable orderedHighScoresList : BasicArrayList
    [<DefaultValue(false)>] val mutable name : string
    [<DefaultValue(false)>] val mutable heading : string
    [<DefaultValue(false)>] val mutable columnOneHeading : string
    [<DefaultValue(false)>] val mutable columnTwoHeading : string
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not HighScores.jclinitDone then
            HighScores.jclinitDone <- true
            HighScores.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_HighScores() : unit =
        this.orderedHighScoresList <- (new BasicArrayListD())
        this.columnOneHeading <- "Name"
        ()
    
    new (name: string, heading: string, columnTwoHeading: string) as this =
        {  }
        then
            this.jfields_HighScores()
            this.jctor1(name, heading, columnTwoHeading)
    member this.jctor1(name: string, heading: string, columnTwoHeading: string) : unit =
        this.name <- name
        this.heading <- heading
        this.columnTwoHeading <- columnTwoHeading
        ()
    
    abstract setList : orderedHighScoresList: BasicArrayList -> unit
    default this.setList(orderedHighScoresList: BasicArrayList) : unit =
        this.orderedHighScoresList <- orderedHighScoresList
    
    abstract getList : unit -> BasicArrayList
    default this.getList() : BasicArrayList =
        this.orderedHighScoresList
    
    abstract getName : unit -> string
    default this.getName() : string =
        this.name
    
    abstract getTotal : unit -> int
    default this.getTotal() : int =
        this.getList().size()
    
    abstract addHighScore : newHighScore: HighScore -> unit
    default this.addHighScore(newHighScore: HighScore) : unit =
        ignore (this.orderedHighScoresList.add(newHighScore))
    
    abstract getHeading : unit -> string
    default this.getHeading() : string =
        this.heading
    
    abstract getColumnOneHeading : unit -> string
    default this.getColumnOneHeading() : string =
        this.columnOneHeading
    
    abstract getColumnTwoHeading : unit -> string
    default this.getColumnTwoHeading() : string =
        this.columnTwoHeading
    
    abstract isBestScore : newHighScore: HighScore -> bool
    default this.isBestScore(newHighScore: HighScore) : bool =
        false
    
    override this.ToString() : string =
        let mutable stringBuffer : StringMaker = (new StringMaker())
        ignore (stringBuffer.append("HighScores: "))
        ignore (stringBuffer.append(this.heading))
        ignore (stringBuffer.append(CommonSeps.getInstance().SPACE))
        ignore (stringBuffer.append(CommonLabels.getInstance().TOTAL_LABEL))
        ignore (stringBuffer.appendint(this.orderedHighScoresList.size()))
        stringBuffer.ToString()
    interface HighScoresInterface with
        member this.getList() : BasicArrayList = this.getList()
        member this.addHighScore(jp0: HighScore) : unit = this.addHighScore(jp0)
        member this.getTotal() : int = this.getTotal()
        member this.isBestScore(jp0: HighScore) : bool = this.isBestScore(jp0)


