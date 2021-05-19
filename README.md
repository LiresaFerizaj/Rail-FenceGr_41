# Siguria e te Dhenave

Detyra 1 - Implementimi i Algoritmit Rail-Fence


Në algoritmin Rail-fence, teksti i thjeshtë shkruhet diagonalisht poshtë në "rails" e njëpasnjëshme, pastaj lëviz lart, dhe kështu me radhë derisa të shkruhet i gjithë teksti i thjesht.Teksti i koduar lexohet më pas në rreshta.

Per shembull, për të kriptuar mesazhin 'HELLO WORLD.  ' me 3 "rails", e shkruajme te tille:

  H - - - O - - - L - - - - - - -  - - - -- - - - - -  -- - --  - - - - - - --  - - - - - - - - - - - - - - - - - - 
  - E - L - W - R - D - - - - - - -- - - - -- - - - - - - - - - - - - - - - - -  --  -- - - - - - - - -  - - -- - - 
  - - L - - - O - - - - - -  - - - - - - - - - - - - - - - - - - - - -- - - - -- - - - - - --  - - - -  

Pastaj lexohet teksti horizontalisht për të marrë tekstin e koduar:
Prej nga kemi:
HOLELWRDLO

Procesi i dekriptimit për algoritmin Rail-fence përfshin rindërtimin e rrjetit diagonal të përdorur për të kriptuar mesazhin. Ne fillojmë të shkruajmë mesazhin, por duke lënë një vijë në vend të hapësirave që do të zënë ende. Gradualisht, ne mund  të zëvendësojmë të gjitha vendet me shkronjat përkatëse dhe të lexoni tekstin e thjeshtë nga tabela.
Fillojmë duke bërë një rrjet me aq rreshta sa çelësi dhe po aq kolona sa gjatësia e tekstit të kodifikuar. Më pas vendosim shkronjën e parë në rreshtin e pare lart majtas, dhe ndërpritet diagonalisht poshtë, aty ku do të jenë shkronjat. Kur kthehemi në rreshtin e sipërm, vendosim shkronjën tjetër në tekstin e kodifikuar. Vazhdojmë kështu përgjatë rreshtit dhe fillojmë rreshtin tjetër kur të arrijmë në fund.

Për shembull, nëse merrni tekstin e koduar "HOLELWRDLO", të koduar me një çelës prej 3, filloni duke vendosur "H" në sheshin e parë. Ju pastaj vizatoni hapësirat diagonale poshtë derisa të ktheheni në rreshtin e sipërm dhe vendosni "O" këtu. Duke vazhduar të plotësoni rreshtin e sipërm, merrni modelin më poshtë.


H . . . O . . . L . . 
. E . L . W . R . D . 
. . L . . . O . . .  

Prej nga marrim tekstin e thjeshte "HELLOWORLD"
