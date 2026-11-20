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
type MineVectorData =
    [<DefaultValue(false)>] static val mutable private jcell_points : int[][][]
    static member points with get() : int[][][] = (MineVectorData.jclinit(); MineVectorData.jcell_points) and set (jvalue: int[][][]) = (MineVectorData.jclinit(); MineVectorData.jcell_points <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not MineVectorData.jclinitDone then
            MineVectorData.jclinitDone <- true
            MineVectorData.jclinitBody()
    static member private jclinitBody() : unit =
        MineVectorData.jcell_points <- ([| ([| ([| 10; 5 |] : int[]); ([| 2; 6 |] : int[]); ([| 1000; 1000 |] : int[]); ([| 2; 2 |] : int[]); ([| 10; 9 |] : int[]); ([| 1000; 1000 |] : int[]); ([| 10; 2 |] : int[]); ([| 2; 9 |] : int[]); ([| 1000; 1000 |] : int[]); ([| 2; 5 |] : int[]); ([| 10; 6 |] : int[]); ([| 1000; 1000 |] : int[]); ([| 7; 9 |] : int[]); ([| 5; 2 |] : int[]); ([| 1000; 1000 |] : int[]); ([| 7; 2 |] : int[]); ([| 5; 9 |] : int[]); ([| 1000; 1000 |] : int[]) |] : int[][]) |] : int[][][])
        ()
    
    new () =
        {  }


