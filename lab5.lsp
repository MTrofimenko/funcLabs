(defun diff (f x)
  (cond ((numberp f) 0)
        ((eq f x) 1)
        ((eq (car f) '+) `(+ ,(diff (cadr f) x) ,(diff (caddr f) x)))
        ((eq (car f) '-) `(- ,(diff (cadr f) x) ,(diff (caddr f) x)))
        ((eq (car f) '*) `(+ (* ,(caddr f) ,(diff (cadr f) x)) (* ,(cadr f) ,(diff (caddr f) x))))
        ((eq (car f) 'sin) `(* (cos ,(cadr f)) ,(diff (cadr f) x)))
        ((eq (car f) 'cos) `(* (- (sin ,(cadr f)) ,(diff (cadr f) x))))
        ((eq (car f) '^) `(* (* ,(caddr f) (^ ,(cadr f) (- ,(caddr f) 1))) ,(diff (cadr f) x)))))
		
(diff '(- (^ x 5) 10) 'x)	
(diff '(* (^ x 2) 3) 'x)
(diff '(cos (* (^ x 3) 2)) 'x)

