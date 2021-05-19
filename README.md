# Siguria e te Dhenave

Detyra 1 - Implementimi i Algoritmit Rail-Fence

Rail-fence algoritmi (e quajtur edhe një shifër zigzag) është një formë e shifrës klasike të transpozimit. Ajo e merr emrin e saj nga mënyra në të cilën kryhet kriptimi.

Në algoritmin Rail-fence, teksti i thjeshtë shkruhet diagonalisht poshtë në "rails" e njëpasnjëshme, pastaj lëviz lart, dhe kështu me radhë derisa të shkruhet i gjithë teksti i thjesht.Teksti i koduar lexohet më pas në rreshta.

Per shembull, për të kriptuar mesazhin 'HELLO WORLD.  ' me 3 "rails", teksti i enkriptuar na del "HOLELWRDLO":

 

Procesi i dekriptimit për algoritmin Rail-fence përfshin rindërtimin e rrjetit diagonal të përdorur për të kriptuar mesazhin. Ne fillojmë të shkruajmë mesazhin, por duke lënë një vijë në vend të hapësirave që do të zënë ende. Gradualisht, ne mund  të zëvendësojmë të gjitha vendet me shkronjat përkatëse dhe të lexoni tekstin e thjeshtë nga tabela.
Fillojmë duke bërë një rrjet me aq rreshta sa çelësi dhe po aq kolona sa gjatësia e tekstit të kodifikuar. Më pas vendosim shkronjën e parë në rreshtin e pare lart majtas, dhe ndërpritet diagonalisht poshtë, aty ku do të jenë shkronjat. Kur kthehemi në rreshtin e sipërm, vendosim shkronjën tjetër në tekstin e kodifikuar. Vazhdojmë kështu përgjatë rreshtit dhe fillojmë rreshtin tjetër kur të arrijmë në fund.

Për shembull, nëse marrim tekstin e koduar "HOLELWRDLO", të koduar me një çelës prej 3, fillojmë duke vendosur "H" në sheshin e parë. Pastaj vizatojmë hapësirat diagonale poshtë derisa të kthehemi në rreshtin e sipërm dhe vendosim "O" këtu. Duke vazhduar të plotësojmë rreshtin e sipërm, marrim tekstin e thjeshte "HELLOWORLD"


Algoritmi Rail-fence  është shumë i lehtë për t’u zbatuar. Sidoqoftë, nuk është i sigurt, pasi ekziston një numër i kufizuar i çelësave të përdorshëm, veçanërisht për mesazhet e shkurtra (që të ketë lëvizje të mjaftueshme të shkronjave, gjatësia e mesazhit duhet të jetë te pakten sa dyfishi i çelësit, por mundësisht 3 herë çelësi). Këto mund t'i përpunoni mjaft shpejt me dorë, dhe madje edhe më shpejt me një kompjuter.


Përdorimi i nulls mund të ketë gjithashtu një efekt të dëmshëm në sigurinë e shifrës, pasi një përgjues mund t'i përdorë ato për të identifikuar se ku është fundi i rreshtit, dhe kështu të ketë një hamendje të ndjeshme në çelës. Kjo mund të shmanget duke përdorur një shkronjë më të zakonshme, të tilla si "E", për të mbushur hapësirat null, pasi do të jetë akoma e qartë për marrësin se këto nuk janë pjesë e mesazhit pasi ato do të shfaqen në fund të tekstit të thjeshtë . Rail-fence Cipher gjithashtu mund të përdoret pa përdorimin e nulleve.

