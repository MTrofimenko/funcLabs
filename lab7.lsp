(defun maximum (list)
 (cond ((null list)
        nil)
       ((null (rest list))
        (first list))
       ((> (first list) (second list))
        (maximum (cons (first list)
                       (rest (rest list)))))
       (t
        (maximum (rest list)))))

(defun minimum (list)
 (cond
       ((null list)                      ; list is empty
        nil)
       ((null (rest list))               ; only one element
        (first list))
       ((< (first list) (second list))   ; if first element is smaller than second
        (minimum (cons (first list)      ; call minimum without second element 
                       (rest (rest list)))))
       (t                                ; second is equal or smaller
        (minimum (rest list)))))         ; call minimum without first element

(print (minimum (list -9 -2 3)))
(print (maximum (list -9 -2 3)))
 
(print(/ (* (minimum (list -9 -2 3)) (maximum (list -9 -2 3))) 2))
