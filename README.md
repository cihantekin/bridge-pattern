# bridge-pattern

sirketin giderlerini hesaplarken agacin yapragi olan employee kadar cikan ve onun ucretini alarak hesaplamalar yapan bir agac yapisi olarak dusunulebilir.
tum roller (developer, ba, po ...) bu abstract Employee classindan turerler
yaprak olarak bu roller dusunulebilir ve composite olarak da bu rollerin yer aldigi departmanlar dusunulebilir
departman giderleri hesaplanirken bu departmanda yer alan calisanlarin maaslari toplanir ve ortak departman giderleri bunun uzerine eklenir
agac yapisindaki son adimi da company olarak dusunebiliriz
company giderleri hesaplanirken de companydeki departmanlarin giderleri + ortak company giderleri hesaplanir
