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
type HealthVectorData =
    [<DefaultValue(false)>] static val mutable private jcell_points : int[][][]
    static member points with get() : int[][][] = (HealthVectorData.jclinit(); HealthVectorData.jcell_points) and set (jvalue: int[][][]) = (HealthVectorData.jclinit(); HealthVectorData.jcell_points <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not HealthVectorData.jclinitDone then
            HealthVectorData.jclinitDone <- true
            HealthVectorData.jclinitBody()
    static member private jclinitBody() : unit =
        HealthVectorData.jcell_points <- ([| ([| ([| 2; 1 |] : int[]); ([| 3; 2 |] : int[]); ([| 3; 2 |] : int[]); ([| 4; 1 |] : int[]); ([| 4; 1 |] : int[]); ([| 5; 1 |] : int[]); ([| 5; 1 |] : int[]); ([| 6; 2 |] : int[]); ([| 6; 2 |] : int[]); ([| 6; 3 |] : int[]); ([| 6; 3 |] : int[]); ([| 3; 6 |] : int[]); ([| 3; 6 |] : int[]); ([| 0; 3 |] : int[]); ([| 0; 3 |] : int[]); ([| 0; 2 |] : int[]); ([| 0; 2 |] : int[]); ([| 1; 1 |] : int[]); ([| 1; 1 |] : int[]); ([| 2; 1 |] : int[]); ([| 1000; 1000 |] : int[]) |] : int[][]) |] : int[][][])
        ()
    new () =
        {  }


