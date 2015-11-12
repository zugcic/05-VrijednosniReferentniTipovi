VrijednosniReferentiTip
=======================

Pridruživanje
-------------
Usporedba pridruživanja objekata vrijednosnog i referentnog tipa.
Prilikom pridruživanjem vrijednosnih tipova stvara se preslika -
ako naknadno mijenjamo polje u jednom objektu, vrijednosti u 
drugom objektu ostaju nepromijenjene.
Prilikom pridruživanja referentih tipova, radi se "plitka preslika"
(preslikavaju se samo reference). Zbog toga će promjene na jednom
objektu automatski povlačiti promjene na drugom.


Zapakiravanje
-------------
Unutar petlje se jedan te isti objekt vrijednosnog tipa dodaje u
kolekciju. Pri tome se objekt preslikava na hrpu (proces zapakiravanja)
- stvara se više instanci od istog objekta.


Otpakiravanje
-------------
Prilikom otpakiravanja moramo napraviti pretvorbu (cast) u izvorni tip.
U protivnom će biti bačena iznimka InvalidCastException. Čak i ako 
naknadno želimo napraviti pretvorbu otpakiranog objekta, prvo trebamo
pretvoriti u izvorni tip, a tek potom u željeni tip.


GenerickaLista
--------------
Kod generičke kolekcije nema zapakiravanja prilikom dodavanja 
vrijednosnih tipova odnosno otpakiravanja prilikom dohvaćanja!
(usporediti IL kod s prethodnim: nema naredbi box i unbox)
